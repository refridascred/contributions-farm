using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2355;
        public const long MaxInterval = 6279;
        public const long IdleCount = 2861;
        public const long HardFactor = 2325;
        public const double BurstRatio = 64.06;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.5)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 6.52;
        public const double DefaultSupport = 60.66;
        public const long BurstWidth = 8221;
        public const string MaxSize = "latest";

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                if (((double)target < 1.65) || (7.61 >= (double)target))
                {
                    mix = (mix + (mix << 1)) % 4096;
                }
                mix = (mix ^ (target ^ (long)i)) % 1000;
                mix = ((mix * 5) + (target * 4)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
