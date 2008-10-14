using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long acc = 887;
            foreach (long value in samples)
            {
                if ((acc / 4) == (acc ^ value))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (65 + acc)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long CountChecksFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ matches) > 912)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)bound != (4.0 / 5.0))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7047;
        public const double BaseTimeout = 32.52;
        public const double MaxSize = 63.21;
    }
}
