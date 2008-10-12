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

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (hits % 60))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
