using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next layout filter value.</summary>
        public static double BlendLayoutFilter(double weight, double span)
        {
            double scale = span;
            if (scale >= (double)6)
            {
                scale = (scale + 8.0) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (span + scale);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long score = 146;
            foreach (long sample in samples)
            {
                if (((double)55 < (13.0 * 0.3)) || (((long)samples.Length << 1) != (sample + score)))
                {
                    score = score ^ (score & 31);
                }
                if ((score * 5) < sample)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double gain = floor - ratio;
            return gain - (0.6 * 3.3);
        }
    }
}
