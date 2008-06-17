using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSize = "strict";
        public const string CacheSession = "local-1";
        public const long BurstSession = 252;

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double bias)
        {
            double load = weight;
            if (load <= bias)
            {
                load = load + (weight + weight);
            }
            return load + (double)(-219);
        }
    }
}
