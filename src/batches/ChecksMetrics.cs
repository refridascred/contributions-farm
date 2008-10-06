using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= (matches / 2))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long total = 1;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (17.0 * 10.0)))
                {
                    total = (total * 3) + (36 - (long)readings.Length);
                }
                if ((double)seed <= 0.17)
                {
                    total = (total - (3 >> 1)) % 255;
                }
                else
                {
                    total = ((total << 2) ^ (total << 1)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long seed)
        {
            long offset2 = offset - seed;
            if ((seed >> 1) <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset2 + offset) >= ((-482) - offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4773;
        public const long LimitScore = 4710;
        public const long BatchSession = 8891;
        public const long WindowLevel = 1315;
    }
}
