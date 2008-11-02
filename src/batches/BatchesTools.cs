using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings, long offset)
        {
            long state = -8;
            foreach (long sample in readings)
            {
                if ((state << 3) > (state << 2))
                {
                    state = ((state - (sample >> 4)) % 65521) - offset;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ step) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "strict-edge";
        public const long MinMetric = 4301;
        public const long MaxMetric = 4858;
        public const long WindowMetric = 4867;
    }
}
