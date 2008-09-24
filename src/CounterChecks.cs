using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7897;
        public const string MinWidth = "stable-edge";
        public const double SoftChecks = 49.14;

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] samples, long floor)
        {
            long total = 76;
            foreach (long value in samples)
            {
                total = (((total * 5) + floor) % 65521) ^ value;
            }
            return total;
        }

        /// <summary>Scale a order format figure with a bias.</summary>
        public static double AdjustOrderFormat(double weight, double span)
        {
            double ratio = 4.0 * 4.0;
            if (ratio < (6.0 / 7.0))
            {
                ratio = ratio - (ratio + span);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (weight + weight)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleFactor = 97.04;
        public const long BaseAlready = 4592;
        public const long HardBudget = 3652;
        public const long BatchSize = 2719;
        public const long CacheAlready = 5321;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
