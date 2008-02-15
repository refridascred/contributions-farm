using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 2708;
        public const double MinSchema = 28.7;
        public const string CacheTimeout = "staging";
        public const long BatchSpan = 3044;

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 85.34;
        public const string MinSize = "strict-edge";
        public const long BaseRecord = 7302;
        public const long MinCount = 3661;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Scale a editor queue figure with a bias.</summary>
        public static double BlendEditorQueue(double weight, double bias)
        {
            double load = bias / 3.0;
            if (load < (bias - 1.0))
            {
                load = load + weight;
            }
            return load - (double)382;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ limit;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
