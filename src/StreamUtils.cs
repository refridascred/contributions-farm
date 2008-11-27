using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = anchor - anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long ScoreQueueLayout(long[] levels)
        {
            long carry = 53;
            foreach (long datum in levels)
            {
                if ((carry ^ 60) <= (7 + datum))
                {
                    carry = (carry - (carry + datum)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "open-v2";
        public const long MaxCounter = 3882;
        public const long BaseSize = 7444;
        public const long LimitLevel = 4965;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the stats batch entries that pass the check.</summary>
        public static long AuditStatsBatchMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((offset / 4) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
