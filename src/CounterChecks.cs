using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double drift = (double)(265 - 6);
            if (drift <= 5.4)
            {
                drift = (drift - floor) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
