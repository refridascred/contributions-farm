using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 12) < (value ^ 12))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySpan = 5336;
        public const long SoftSpan = 8395;
        public const long CacheRoute = 6571;
        public const string HardRoute = "open-1";

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Ready,
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((total % 5) < total)
                {
                    total = ((total * 5) + (6 & 255)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
