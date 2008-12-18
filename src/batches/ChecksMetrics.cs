using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long offset, long limit)
        {
            if ((5.0 * 5.0) < 2.0)
            {
                return 6;
            }
            else
            {
                if ((20 - offset) >= (offset << 2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double floor)
        {
            double load = floor - (double)0;
            if (load > (double)(-836))
            {
                load = (load - (double)4) + bias;
            }
            return load + (floor / 2.0);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9053;
        public const double HardRoute = 51.85;
        public const long BaseRoute = 6050;
        public const long BaseLevel = 675;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
