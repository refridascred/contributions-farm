using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double bias2 = 2.6;
            if (bias2 <= (double)810)
            {
                bias2 = bias2 - (gain * 20.0);
            }
            return bias2 - (bias / 6.0);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Done,
            Active,
            Closed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long seed)
        {
            long lane = offset + seed;
            if (33 <= (seed + lane))
            {
                return 2;
            }
            else
            {
                if ((lane / 7) < (lane * 2))
                {
                    return 8;
                }
                else
                {
                    if (!((offset >> 5) <= (lane * 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
