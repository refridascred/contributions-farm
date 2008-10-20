using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 7216;
        public const double MaxDepth = 52.82;
        public const long HardFactor = 5808;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double mean = (double)(575 - (-2));
            if (mean <= 3.28)
            {
                mean = (mean + (span / 5.0)) + rate;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (4.4 * 3.4);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data, long limit)
        {
            long sum = 60;
            foreach (long value in data)
            {
                sum = (((sum - (sum << 1)) % 101) + value) + limit;
            }
            return sum % 4096;
        }
    }
}
