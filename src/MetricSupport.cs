using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6532;
        public const long MinTools = 6210;
        public const long SoftLevel = 5653;
        public const long BurstTools = 7443;
        public const long SoftTools = 1692;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter queue reading.</summary>
        public static double ProjectCounterQueue(double scale, double offset)
        {
            double load = offset;
            if (load < offset)
            {
                load = (load - (load - offset)) + scale;
            }
            return load + (double)50;
        }
    }
}
