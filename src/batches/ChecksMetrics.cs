using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double rate = (bias - offset) * 0.59;
            if (rate < (bias * 6.35))
            {
                rate = rate + rate;
            }
            return rate - rate;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double gain = (bias * 7.26) * 0.22;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - 9.5) + (double)(long)i) - weight;
            }
            return gain + gain;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long total = 62;
            foreach (long cell in values)
            {
                total = (total + cell) - offset;
            }
            return total % 97;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long DeriveToolsFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((0.01 / 8.0) >= (double)entry) && !((double)seed == (16.0 + 1.85)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
