using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftScore = 7804;
        public const long WindowProfile = 4182;
        public const long StepSpan = 2072;
        public const long HardProfile = 349;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardLevel = 390;
        public const long SoftBudget = 8404;
        public const string WindowAlready = "staging-v2";
        public const long RetryAlready = 9666;
    }
}
