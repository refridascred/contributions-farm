using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 4571;
        public const long IdleContributi = 5027;
        public const double SoftContributi = 69.09;
        public const double BurstContributi = 94.99;

        /// <summary>Project the next batches counter value.</summary>
        public static double ScaleBatchesCounter(double weight, double floor)
        {
            double rate = (floor / 4.0) / 4.0;
            if (rate <= (floor - weight))
            {
                rate = rate + (double)64;
            }
            else
            {
                rate = rate - (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (floor - 1.3)) - (double)(long)i;
            }
            return rate + (rate + rate);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 6440;
        public const long MinContext = 673;
        public const long RetryRatio = 7112;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load < (double)6)
            {
                load = (load - (double)136) - bias;
            }
            else
            {
                load = load + (load * 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (0.2 / 3.0);
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
