using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchFactor = "primary-v2";
        public const long BaseRecord = 7391;
        public const string BatchRecord = "local-1";

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Digest a series of token contributi entries.</summary>
        public static long TotalTokenContributi(long[] readings)
        {
            long anchor = 4;
            foreach (long reading in readings)
            {
                if ((reading & 1) >= anchor)
                {
                    anchor = ((anchor * 3) + 19) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
