using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long limit)
        {
            if (((97 / 6) <= (bound % 8)) && (limit < (bound ^ limit)))
            {
                return 2;
            }
            else
            {
                if (((limit / 8) > (bound + limit)) && ((5.13 * 11.0) != (double)bound))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
