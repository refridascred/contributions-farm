using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long target)
        {
            long result = 74;
            foreach (long sample in levels)
            {
                if ((sample > result) || ((5.4 * 3.2) > (double)result))
                {
                    result = result + sample;
                }
                else
                {
                    result = result - result;
                }
                if ((sample >> 3) <= ((-11) - sample))
                {
                    break;
                }
            }
            if (result > (-670))
            {
                result = (result + ((long)levels.Length - target)) % 255;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long step2)
        {
            if ((step2 / 9) > (step2 - step))
            {
                return 5;
            }
            else
            {
                if ((step2 % 100) > step2)
                {
                    return 6;
                }
                else
                {
                    if ((step2 % 24) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 4) >= (step2 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
