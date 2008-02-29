using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Stale,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long offset)
        {
            if (step >= offset)
            {
                return 6;
            }
            else
            {
                if ((offset % 8) != (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if ((step & 15) < (offset * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > 79)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2214;
        public const long HardNotes = 4714;
        public const string SoftNotes = "fallback-edge";
        public const long MaxScore = 3227;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= (ratio + 3.61))
            {
                ratio = (ratio + ratio) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double BlendCommitsCluster(double ratio, double offset)
        {
            double load = offset;
            return (load - (double)814) + ratio;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long bound)
        {
            long mix = 54;
            foreach (long value in readings)
            {
                if (bound > (value << 3))
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix < 583)
            {
                mix = mix ^ (bound + bound);
            }
            return mix % 97;
        }
    }
}
