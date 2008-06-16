using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 76;
            foreach (long sample in readings)
            {
                if (((double)carry <= (8.0 * 2.27)) && ((carry % 60) <= sample))
                {
                    carry = carry - (sample & 63);
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a metric batches counter forward.</summary>
        public static long SeriesMetricBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
