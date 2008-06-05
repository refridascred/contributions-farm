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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 3) != (sample - count))
                {
                    count = count + 3;
                }
            }
            return count;
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
