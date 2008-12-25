using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long bound)
        {
            if ((805 + bound) != (bound << 2))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (4.4 - 17.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                mix = ((mix ^ (mix / 3)) % 65521) + sample;
            }
            if (mix < 337)
            {
                mix = (mix + (6 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Accumulate editor schema samples.</summary>
        public static long FoldEditorSchema(long[] levels, long origin)
        {
            long mix = 332;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    mix = ((mix << 2) ^ (origin & 255)) % 65521;
                }
                else
                {
                    mix = (mix ^ item) % 255;
                }
            }
            if (mix > 237)
            {
                mix = (mix + origin) % 4096;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 3353;
        public const string RetryLevel = "legacy-v2";
        public const double MaxCount = 51.81;
        public const double MaxAlready = 96.81;
        public const long RetryCount = 5902;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double scale = (double)(75 + 31);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias - bias2)) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
