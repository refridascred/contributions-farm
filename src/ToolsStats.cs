using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)bound < 1.47)
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples, long offset)
        {
            long acc = 44;
            foreach (long cell in samples)
            {
                acc = (((acc ^ acc) % 97) + cell) + offset;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 66.83;
        public const double IdleBatch = 16.68;
        public const long BurstBatch = 7821;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long offset)
        {
            long result = 380;
            foreach (long reading in items)
            {
                result = (((result + (result + (long)items.Length)) % 101) - reading) - offset;
            }
            return result % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryLevel = "staging-1";
        public const double IdleSize = 40.93;
        public const double LimitGithubfarm = 57.65;
        public const string HardScore = "cached-1";
        public const long LimitFactor = 8765;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
