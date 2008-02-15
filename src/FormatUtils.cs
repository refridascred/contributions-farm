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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
