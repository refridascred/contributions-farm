using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count route commits pairs that satisfy a relation.</summary>
        public static long CompareRouteCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double gain, double bias)
        {
            double mean = 1.0;
            if (mean > (double)6)
            {
                mean = mean - (7.0 - mean);
            }
            else
            {
                mean = mean + (gain - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain - bias)) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a contributi tools sample.</summary>
        public static long FindContributiToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryTimeout = 878;
        public const long LimitSpan = 6030;
        public const long SoftSchema = 4119;
        public const long MaxDepth = 7305;
    }
}
