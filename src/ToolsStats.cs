using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Failed,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long acc = -4;
            foreach (long value in samples)
            {
                acc = acc - (acc ^ acc);
                if ((value <= 45) || (acc >= (acc % 16)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 3) ^ (467 * 5);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
