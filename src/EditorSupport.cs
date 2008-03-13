using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double load = bias2;
            if (load < (double)40)
            {
                load = load - bias;
            }
            return load - (9.1 + load);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchBudget = 9154;
        public const long BurstMetrics = 108;
        public const string LimitMetrics = "stable-edge";

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((98 << 1) >= result)
                {
                    result = ((result << 3) ^ (seed + result)) % 255;
                }
                if ((seed - seed) != (long)i)
                {
                    result = result - (result % 100);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long TallyMetricsBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count > (6.3 - 14.0))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
