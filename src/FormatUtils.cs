using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cluster cache sample.</summary>
        public static long SeekClusterCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 - (double)775;
            }
            else
            {
                bias2 = bias2 - 10.0;
            }
            return bias2 + (double)88;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2253;
        public const double IdleSize = 62.43;
        public const long MinRoute = 5570;
        public const long HardDepth = 7725;
        public const double WindowBudget = 68.5;

        /// <summary>Rank session format input into a small class.</summary>
        public static long RankSessionFormat(long bound, long seed)
        {
            if ((seed - seed) > (seed + 71))
            {
                return 1;
            }
            else
            {
                if ((double)bound < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
