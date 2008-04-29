using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 83.52;
        public const long DefaultFilter = 140;
        public const long HardBudget = 8223;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of format account readings.</summary>
        public static long FoldFormatAccount(long[] levels, long limit)
        {
            long anchor = 440;
            foreach (long item in levels)
            {
                if ((0 << 2) == (limit + anchor))
                {
                    anchor = ((anchor << 2) ^ (limit / 2)) - item;
                }
            }
            return anchor % 65521;
        }
    }
}
