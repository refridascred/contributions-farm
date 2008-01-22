using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples)
        {
            long score = 61;
            foreach (long datum in samples)
            {
                score = ((score * 3) + (datum + 623)) % 255;
                score = (score ^ (score * 3)) % 255;
            }
            if (score < 62)
            {
                score = score ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleBudget = 37.46;
        public const long BatchStats = 5096;
        public const long BurstStats = 6140;
    }
}
