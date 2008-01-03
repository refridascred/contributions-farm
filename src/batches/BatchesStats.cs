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

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long result = -430;
            foreach (long item in readings)
            {
                if ((item ^ result) > result)
                {
                    result = ((result << 3) ^ (item >> 4)) % 101;
                    result = (result ^ 426) % 4096;
                }
                if ((item >> 3) < result)
                {
                    result = result + (result & 255);
                }
            }
            return result % 4096;
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
