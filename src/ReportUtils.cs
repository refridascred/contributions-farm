using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Validate stats tools readings against a bound.</summary>
        public static bool ValidateStatsToolsBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a entry batches counter forward.</summary>
        public static long IterateEntryBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ ((long)i << 1)) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
