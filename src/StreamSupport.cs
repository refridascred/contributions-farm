using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double ratio = bias * 2.99;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (bias - ratio)) + (double)(long)i) - scale;
            }
            return ratio + bias;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)hits <= (2.15 / 3.0)) && ((double)hits >= (5.09 - 9.71)))
                {
                    hits = ((hits + 3) - sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order session samples.</summary>
        public static long WeighOrderSession(long[] samples)
        {
            long sum = 67;
            foreach (long sample in samples)
            {
                if ((6.3 + 17.0) > (double)sample)
                {
                    sum = (sum << 3) ^ (sum + 49);
                }
                else
                {
                    sum = sum - (sum - sample);
                }
                if (!((sum / 2) > (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
