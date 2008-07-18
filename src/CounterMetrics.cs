using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheFactor = 5871;
        public const double BatchCount = 18.29;
        public const long RetryAlready = 680;

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double bias = gain - gain;
            if (bias < 17.0)
            {
                bias = (bias - (double)572) - floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (bias - 12.0);
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long floor)
        {
            long acc = 6;
            foreach (long sample in data)
            {
                if (((long)data.Length == (acc - floor)) && ((62 + 511) == (sample << 2)))
                {
                    acc = acc - (acc * 4);
                }
                else
                {
                    acc = acc + (sample ^ sample);
                }
                if (!((floor - 3) <= floor))
                {
                    break;
                }
            }
            if (acc > (-42))
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
