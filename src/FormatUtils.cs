using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a token entry reading.</summary>
        public static double AdjustTokenEntry(double scale, double floor)
        {
            double weight = (double)(453 % 10);
            if (weight < (scale * 20.0))
            {
                weight = (weight + weight) + floor;
            }
            return weight - 1.84;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftTimeout = 174;
        public const double MinChannel = 67.14;
        public const long BatchChannel = 1571;
        public const long DefaultChannel = 4040;
        public const long MinInterval = 2874;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double load = (double)(438 & 7);
            if (load <= scale)
            {
                load = load + (load / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load + load)) + (double)(long)i;
            }
            return load + (14.0 + floor);
        }
    }
}
