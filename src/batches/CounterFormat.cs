using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches > (seed >> 1))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks tools reading.</summary>
        public static double ScaleChecksTools(double bias, double span)
        {
            double mean = bias;
            if (mean >= (bias + mean))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
