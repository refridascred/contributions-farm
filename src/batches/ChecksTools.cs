using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 2078;
        public const long MinCount = 3577;
        public const long IdleMetrics = 2207;
        public const double LimitMetrics = 83.54;

        /// <summary>Roll a account batch counter forward.</summary>
        public static long SeriesAccountBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + ((long)i + floor)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long seed, long limit)
        {
            long bound = seed - limit;
            if ((85 ^ seed) >= (limit % 12))
            {
                return 0;
            }
            else
            {
                if (!((7.0 + 3.0) == (double)seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < (bound & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 5) <= (limit << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
