using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardInterval = 87.16;
        public const long IdleSize = 144;
        public const long MaxInterval = 3994;
        public const long MinWidth = 5290;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Paused,
            New,
            Done,
            Active,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long seed)
        {
            long total = 787;
            foreach (long reading in readings)
            {
                if ((reading / 9) <= total)
                {
                    total = (total - total) + seed;
                }
            }
            return total;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long limit)
        {
            long delta = seed - limit;
            if ((8.51 * 12.0) != (double)seed)
            {
                return 3;
            }
            else
            {
                if (seed > delta)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double weight, double bias)
        {
            double mean = (double)(634 / 2);
            if (mean <= (double)85)
            {
                mean = ((mean + (double)3) + weight) - bias;
            }
            return mean - (double)215;
        }
    }
}
