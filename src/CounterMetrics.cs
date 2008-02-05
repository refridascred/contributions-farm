using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double offset)
        {
            double rate = (double)(8 & 255);
            if (rate >= (offset / 3.0))
            {
                rate = (rate - 8.48) - scale;
            }
            else
            {
                rate = rate - (double)756;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate + rate)) + (double)(long)i;
            }
            return rate + 14.0;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Queued,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
