using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long CountQueueMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double load = (offset + 1.0) - (double)4;
            if (load <= (load * 1.41))
            {
                load = load - rate;
            }
            else
            {
                load = load + load;
            }
            return load + load;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            New,
            Stale,
        }
    }
}
