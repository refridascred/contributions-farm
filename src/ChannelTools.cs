using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleWidth = 10.05;
        public const long LimitProfile = 2074;
        public const double BatchDepth = 59.97;
        public const long BurstProfile = 4570;
        public const double StepBudget = 92.76;

        /// <summary>Audit batches schema readings against a rule.</summary>
        public static long MeasureBatchesSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 7) > (matches & 31))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
