using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double mean = rate / 3.0;
            if (mean < (mean / 3.0))
            {
                mean = mean - (rate * 3.37);
            }
            else
            {
                mean = mean + (double)8;
            }
            return mean - (rate - span);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 7714;
        public const string IdleCount = "legacy-1";
        public const double SoftContext = 0.26;
        public const long LimitRatio = 907;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 67;
        public const long RetryContext = 7675;
        public const long DefaultInterval = 9511;
        public const long BurstInterval = 5718;
    }
}
