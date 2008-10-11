using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = 5;
            foreach (long sample in series)
            {
                anchor = (anchor - (anchor ^ anchor)) % 255;
                if ((sample + 26) == (anchor >> 1))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = (anchor - (anchor + sample)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4201;
        public const string BaseMetrics = "open-1";
        public const long MinMetrics = 1411;
        public const long BaseDepth = 4467;
        public const long StepMetrics = 8710;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Draft,
            Done,
            Pending,
            Dropped,
        }
    }
}
