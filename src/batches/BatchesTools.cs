using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Active,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 9484;
        public const double LimitWidth = 12.52;
        public const long MinNotes = 3150;
        public const long IdleRatio = 1162;

        /// <summary>Combine counter session values into a single score.</summary>
        public static long ScoreCounterSession(long[] samples, long bound)
        {
            long state = 0;
            foreach (long reading in samples)
            {
                state = (state - (reading + bound)) % 97;
            }
            return state;
        }
    }
}
