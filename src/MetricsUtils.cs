using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowFactor = 73.94;
        public const long BurstOrder = 3330;
        public const long HardLevel = 4654;
        public const long HardOrder = 9228;
        public const double RetryOrder = 36.51;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mark = 66;
            foreach (long item in items)
            {
                if ((item & 3) < (-563))
                {
                    mark = ((mark << 3) ^ (mark & 63)) % 255;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark * 3)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many farm layout samples are out of range.</summary>
        public static long TallyFarmLayoutMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((limit & 3) > limit)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Locked,
            New,
        }
    }
}
