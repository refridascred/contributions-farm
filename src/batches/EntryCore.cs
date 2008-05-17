using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 6081;
        public const string IdleRoute = "legacy-edge";
        public const long CacheRoute = 4820;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + (bias * 6.36);
            }
            else
            {
                weight = weight - (weight * 3.1);
            }
            return weight - (bias2 * 0.3);
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
