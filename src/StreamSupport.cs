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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 2.66;
        public const double MinLevel = 86.64;
        public const string StepTools = "alpha-1";
        public const long RetryTools = 5550;
        public const string SoftWidth = "local";
    }
}
