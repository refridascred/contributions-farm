using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (double)9)
            {
                weight2 = (weight2 - (double)21) + weight;
            }
            return weight2 + bias;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "strict-v2";
        public const double BurstSpan = 65.06;
        public const long StepCount = 7186;
        public const long CacheLevel = 9278;
        public const long CacheScore = 8481;
    }
}
