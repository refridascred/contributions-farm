using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Locked,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1157;
        public const string RetryCommand = "cached-v2";
        public const string BatchCommand = "cached-edge";
    }
}
