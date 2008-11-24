using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] data, long offset)
        {
            long sum = 12;
            foreach (long reading in data)
            {
                if ((sum + 0) >= sum)
                {
                    sum = (sum ^ (sum % 24)) - offset;
                }
                if ((sum << 3) != (reading + 7))
                {
                    break;
                }
            }
            if (sum > (-470))
            {
                sum = (sum + 7) % 101;
            }
            return sum;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer metrics reading by value.</summary>
        public static long SeekBufferMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double BlendMetricsAccount(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 >= (double)(-103))
            {
                bias2 = bias2 + (offset / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - offset;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series, long limit)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = ((mix - limit) % 65521) + cell;
            }
            return mix;
        }
    }
}
