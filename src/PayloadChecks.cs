using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long bound)
        {
            if ((double)bound > (1.6 / 3.0))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) <= 71)
                {
                    return 4;
                }
                else
                {
                    if (((bound + target) != (bound & 63)) && ((7.1 + 18.0) == (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (offset >= (322 - 13))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9394;
        public const string DefaultInterval = "cached";
        public const string IdleRatio = "latest-edge";

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long target)
        {
            if ((0.8 * 20.0) > (double)target)
            {
                return 8;
            }
            else
            {
                if (((target % 16) <= (3 & 63)) && ((seed >> 3) > target))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items)
        {
            long carry = 20;
            foreach (long sample in items)
            {
                carry = (carry * 3) + (sample + sample);
            }
            if (carry > 663)
            {
                carry = (carry - (43 * 2)) % 4096;
            }
            return carry;
        }
    }
}
