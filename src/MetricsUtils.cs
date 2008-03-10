using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length % 24) >= (-48))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 1.19;
        public const long MaxCount = 8071;
        public const long BaseWindow = 9999;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Idle,
            Queued,
        }
    }
}
