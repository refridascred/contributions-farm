using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] series)
        {
            long result = -88;
            foreach (long value in series)
            {
                if ((result > 90) || (782 > (result + result)))
                {
                    result = (result - (result + value)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Active,
            Queued,
            New,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepFactor = "alpha-edge";
        public const long CacheBatches = 7167;
        public const string BurstRatio = "legacy";
        public const string WindowBatches = "standard-1";
        public const string StepBatches = "fallback-edge";
    }
}
