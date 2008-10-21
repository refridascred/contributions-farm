using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double ratio = (bias * 4.43) * 2.85;
            if (ratio >= (double)(-7))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.7);
            }
            return ratio - (4.4 + scale);
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 3558;
        public const long BaseLevel = 4008;
        public const long MaxGraph = 5385;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
