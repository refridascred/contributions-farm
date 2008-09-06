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

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
