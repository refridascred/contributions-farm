using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mix = 291;
            foreach (long reading in data)
            {
                mix = (mix - (reading >> 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 70.05;
        public const long BurstSpan = 7819;
        public const long HardReport = 830;
        public const string RetryReport = "primary-edge";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
