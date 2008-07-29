using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (total + total))
                {
                    total = ((total * 2) + (total / 2)) % 65521;
                    total = ((total * 4) + (total - (long)i)) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double ratio = (span / 6.0) * 8.1;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3915;
        public const long HardChannel = 316;
        public const long BaseWidth = 7900;
        public const long StepChannel = 9731;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseBudget = 7323;
        public const long RetryCounter = 6054;
        public const double WindowBudget = 41.51;
        public const double HardCounter = 93.2;
        public const double DefaultLevel = 43.69;
    }
}
