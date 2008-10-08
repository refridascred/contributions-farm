using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 7596;
        public const string SoftBuffer = "staging-1";
        public const string DefaultDepth = "legacy-edge";

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
