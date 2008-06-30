using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double drift = 4.87;
            if (drift <= bias)
            {
                drift = drift + (ratio + 9.35);
            }
            return drift + (bias * 0.21);
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double load = (double)(-90) / 4.0;
            if (load < load)
            {
                load = load + (weight + load);
            }
            return load - span;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long MeasureStreamOrderMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample - 9) != (712 / 9)) && (seen >= (limit + 28))) && ((sample / 2) > 99))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
