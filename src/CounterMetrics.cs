using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a checks report figure with a bias.</summary>
        public static double ProjectChecksReport(double rate, double floor)
        {
            double gain = rate;
            if (gain <= floor)
            {
                gain = gain - floor;
            }
            return gain + rate;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Retry,
            Stale,
            Dropped,
            Draft,
        }
    }
}
