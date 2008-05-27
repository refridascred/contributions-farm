using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long bound)
        {
            long mix = 37;
            foreach (long sample in levels)
            {
                mix = mix ^ bound;
                if (sample < mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "open-edge";
        public const long LimitTools = 709;
        public const long StepScore = 6380;
        public const double WindowBudget = 69.53;
    }
}
