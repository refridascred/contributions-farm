using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 3.88;
        public const string WindowCommits = "alpha-edge";
        public const long MaxBudget = 5076;
        public const long BatchCommits = 9435;
        public const long MinCommits = 7732;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) >= (reading ^ reading))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Pending,
            Queued,
            New,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
