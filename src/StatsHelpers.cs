using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 50.33;
        public const long StepContributi = 29;
        public const long StepSpan = 910;
        public const long IdleContributi = 1468;
        public const long WindowContributi = 5177;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels)
        {
            long sum = 60;
            foreach (long value in levels)
            {
                sum = (((sum * 5) + sum) % 255) - value;
            }
            if (sum < 96)
            {
                sum = ((sum * 2) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            if (!((step << 1) > step))
            {
                return 6;
            }
            else
            {
                if ((floor / 4) <= step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
