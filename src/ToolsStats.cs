using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstTimeout = 3716;
        public const double CacheBatches = 93.99;
        public const long BatchSize = 6154;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Active,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next editor already value from a seed.</summary>
        public static long DeriveEditorAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Failed,
            New,
            Retry,
        }

        /// <summary>Combine metrics checks values into a single score.</summary>
        public static long ScoreMetricsChecks(long[] values)
        {
            long result = -21;
            foreach (long reading in values)
            {
                result = (result * 4) + (reading * 2);
                if ((double)result == (11.0 * 3.2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
