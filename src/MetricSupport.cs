using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double weight2 = (double)381 * 7.07;
            if (weight2 > bias)
            {
                weight2 = (weight2 + (double)69) - weight;
            }
            return weight2 - (double)1;
        }
    }
}
