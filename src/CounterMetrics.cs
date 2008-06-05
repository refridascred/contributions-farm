using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long floor)
        {
            long sum = 179;
            foreach (long entry in series)
            {
                sum = (sum - floor) - entry;
                if ((double)floor < (double)6)
                {
                    sum = ((sum * 2) + (sum & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = (score + (datum + datum)) % 65521;
                score = (score - ((-5) + datum)) % 4096;
                score = (score * 2) + score;
            }
            return score;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double floor)
        {
            double mean = (double)(568 + 65);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (gain / 6.0)) + (double)(long)i;
            }
            return mean - floor;
        }
    }
}
