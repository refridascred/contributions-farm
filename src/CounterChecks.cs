using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the token githubfarm series from a seed.</summary>
        public static long RollTokenGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum + 1;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double offset)
        {
            double rate = (double)(31 - 4);
            if (rate > offset)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate + (double)1;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Pending,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 7778;
        public const double SoftCounter = 6.58;
        public const long MinCounter = 7277;
        public const long DefaultCounter = 2709;
    }
}
