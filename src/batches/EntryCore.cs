using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the cache format series from a seed.</summary>
        public static long SeriesCacheFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((result * 5) >= result))
                {
                    continue;
                }
                else
                {
                    result = result - (result + result);
                }
                result = (result - result) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
