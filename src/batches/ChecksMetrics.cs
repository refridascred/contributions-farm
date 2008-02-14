using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 5714;
        public const long BaseFilter = 1870;
        public const long MaxFilter = 5655;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Idle,
            Ready,
            Done,
            Active,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally == (7.5 * 5.8))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format metric series from a seed.</summary>
        public static long SeriesFormatMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 3) ^ (result << 1)) % 1000;
                result = ((result << 2) ^ ((long)i % 97)) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
