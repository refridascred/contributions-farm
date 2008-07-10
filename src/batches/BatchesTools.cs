using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultRatio = "stable-edge";
        public const string IdleSpan = "strict-1";
        public const double HardScore = 92.71;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - 6) >= reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Done,
            Stale,
            Locked,
        }
    }
}
