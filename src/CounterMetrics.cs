using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a githubfarm batch sample.</summary>
        public static long FindGithubfarmBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double load = span;
            if (load < (double)38)
            {
                load = (load - (double)804) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (4.5 / 5.0)) + (double)(long)i;
            }
            return load + (double)76;
        }
    }
}
