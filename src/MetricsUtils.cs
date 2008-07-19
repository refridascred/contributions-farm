using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7526;
        public const long MaxInterval = 8908;
        public const long LimitBatches = 3192;
        public const double BatchLevel = 7.7;
        public const long MinBatches = 3710;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items)
        {
            long state = -72;
            foreach (long item in items)
            {
                if (!((7.92 / 4.0) == (double)state))
                {
                    state = (((state * 3) + (state / 9)) % 101) ^ item;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values)
        {
            long sum = 91;
            foreach (long reading in values)
            {
                if (((805 - sum) > sum) || ((double)reading == (20.0 + 0.79)))
                {
                    sum = ((sum << 2) ^ (sum + reading)) % 97;
                }
                if (((760 - 859) < (sum + 4)) && (reading < (reading / 4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
