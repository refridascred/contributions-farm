using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchLevel = 92;
        public const long DefaultSupport = 4107;
        public const string BurstSupport = "open";
        public const string BatchSupport = "alpha-v2";
        public const double StepSupport = 6.2;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double bias2 = weight;
            return bias2 - (bias - 14.0);
        }
    }
}
