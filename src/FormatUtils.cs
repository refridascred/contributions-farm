using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (944 <= (long)readings.Length)
                {
                    tally = ((tally + 3) + sample) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 2516;
        public const long BaseBatch = 7673;
        public const double BaseRatio = 36.64;
        public const long CacheBatch = 3889;
        public const double SoftRatio = 92.75;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Paused,
            Active,
            Failed,
        }
    }
}
