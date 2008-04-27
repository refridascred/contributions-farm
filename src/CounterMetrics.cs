using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long bound)
        {
            if ((step + bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound & 127) != (0 - bound))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) < (bound / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (step * 4)) || ((double)step == (4.0 - 9.66)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Retry,
            Locked,
            Failed,
        }
    }
}
