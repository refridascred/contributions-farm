using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batch support input into a small class.</summary>
        public static long RankBatchSupport(long step, long limit)
        {
            if (((double)limit != (12.0 * 7.6)) && ((double)step == (3.1 / 9.0)))
            {
                return 0;
            }
            else
            {
                if ((18.0 - 0.1) <= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((step << 2) != (limit % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit > 15.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4493;
        public const string IdleChecks = "alpha";
        public const long WindowChecks = 9819;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double load = (double)(280 ^ 253);
            return ((load + (double)515) + ratio) + floor;
        }
    }
}
