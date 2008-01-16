using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of schema support entries.</summary>
        public static long WeighSchemaSupport(long[] values)
        {
            long mark = -195;
            foreach (long datum in values)
            {
                if ((datum << 2) >= (mark - mark))
                {
                    mark = (mark - (mark / 8)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = (bias * 1.75) / 6.0;
            if (weight > (ratio + 6.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + 2.84;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (ratio * 7.46);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
