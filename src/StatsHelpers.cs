using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 97.3;
        public const string MinCount = "legacy";
        public const string CacheLevel = "staging-edge";

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 346;
            foreach (long value in data)
            {
                mix = (mix ^ value) % 65521;
                if (((-6) ^ 715) < (value * 2))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7070;
        public const long MaxLevel = 6858;
        public const long BaseFilter = 1717;
        public const long DefaultInterval = 3865;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix << 3) ^ (mix & 7);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] data, long step)
        {
            long total = -128;
            foreach (long value in data)
            {
                if (983 >= (total + value))
                {
                    total = ((total * 4) + step) % 101;
                }
            }
            if (total > (-13))
            {
                total = (total - (9 << 2)) % 1000;
            }
            return total % 65521;
        }
    }
}
