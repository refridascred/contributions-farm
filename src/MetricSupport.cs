using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes editor counter forward.</summary>
        public static long RollNotesEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (score - offset)) % 97;
                if (offset <= (score - 374))
                {
                    score = score + (score * 2);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 4683;
        public const long SoftWidth = 4623;
        public const long DefaultSize = 3740;
        public const long DefaultDepth = 8806;
    }
}
