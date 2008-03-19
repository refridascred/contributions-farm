using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowBudget = "cached-1";
        public const long SoftBudget = 5813;
        public const string DefaultInterval = "fallback";
        public const long LimitSize = 53;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double mean = 9.93;
            if (mean > (weight + weight))
            {
                mean = (mean - 5.0) - bias;
            }
            return mean + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5762;
        public const long SoftWindow = 3407;
        public const double IdleWidth = 55.09;
        public const long StepWindow = 9996;
        public const long IdleWindow = 8051;

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 97.18;
        public const long HardProfile = 6885;
        public const long DefaultBudget = 440;
        public const long MinLevel = 5233;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
