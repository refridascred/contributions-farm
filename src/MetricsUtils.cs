using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "primary-edge";
        public const long BaseCache = 1837;
        public const double RetryScore = 69.66;
        public const double HardSpan = 89.48;

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long WeighBatchStats(long[] values)
        {
            long total = 1;
            foreach (long reading in values)
            {
                if ((reading ^ 6) != (total / 5))
                {
                    total = (total << 2) ^ (total << 1);
                }
            }
            return total;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound ^ 529) >= score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
