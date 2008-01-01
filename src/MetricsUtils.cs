using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double load = (double)(407 & 63);
            if (load >= offset)
            {
                load = (load + load) - weight;
            }
            else
            {
                load = load + offset;
            }
            return load - offset;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double drift = ratio / 4.0;
            return drift + offset;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Ready,
            Paused,
            Locked,
        }
    }
}
