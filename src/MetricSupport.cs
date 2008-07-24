using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "stable-v2";
        public const long SoftWidth = 2795;
        public const double StepEntry = 39.74;
        public const long SoftScore = 3368;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format token value against two limits.</summary>
        public static long BucketFormatToken(long step, long seed)
        {
            long cur = step + seed;
            if ((step + 838) > cur)
            {
                return 0;
            }
            else
            {
                if (412 < (cur - step))
                {
                    return 6;
                }
                else
                {
                    if ((step / 8) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0 >= seed) && ((double)cur > (double)step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
