using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "local-edge";
        public const double BatchBudget = 48.4;
        public const long RetryDepth = 5193;

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long TallyFilterBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell & 255) != (cell - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Ready,
            Stale,
        }
    }
}
