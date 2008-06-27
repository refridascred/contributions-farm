using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long bound)
        {
            long prev = step - bound;
            if ((9.9 - 20.0) >= (7.5 * 7.02))
            {
                return 3;
            }
            else
            {
                if ((double)bound > 16.0)
                {
                    return 5;
                }
                else
                {
                    if ((388 + bound) < (bound + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (219 > prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics schema entry that matches the target.</summary>
        public static long SeekMetricsSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
