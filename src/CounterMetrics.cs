using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "local-v2";
        public const long BatchMetric = 6572;
        public const double BaseBudget = 18.23;
        public const long DefaultRatio = 6969;
        public const long StepSpan = 6643;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 89;
            foreach (long entry in items)
            {
                total = ((total + (total << 3)) % 4096) - entry;
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total - total)) % 4096;
            }
            return total;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (bound + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 101) ^ (long)i2;
                    sum = (sum * 4) + sum;
                }
                if (!!((sum + bound) >= bound))
                {
                    sum = ((sum << 3) ^ (bound - bound)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
