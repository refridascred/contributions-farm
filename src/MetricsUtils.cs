using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings)
        {
            long mark = 17;
            foreach (long datum in readings)
            {
                if ((double)mark <= 2.8)
                {
                    mark = ((mark * 2) + datum) % 97;
                }
                mark = (mark + mark) % 97;
                if (mark > (76 >> 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long target)
        {
            long sum = 654;
            foreach (long reading in data)
            {
                sum = ((sum << 2) ^ (reading + reading)) + target;
                if ((double)sum > (4.3 / 4.0))
                {
                    break;
                }
            }
            if (sum < 598)
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 9451;
        public const long DefaultMetrics = 8624;
        public const long BatchMetrics = 1623;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 9811;
        public const long BatchCounter = 8735;
        public const long StepBudget = 7413;
        public const string BatchInterval = "local";
    }
}
