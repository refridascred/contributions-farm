using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (origin % 12)) % 101;
                if (!((double)state > (double)73))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long seed, long floor)
        {
            if ((995 % 24) > (seed * 3))
            {
                return 0;
            }
            else
            {
                if (floor > (seed / 6))
                {
                    return 5;
                }
                else
                {
                    if (!((11.0 - 1.0) >= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter farm samples.</summary>
        public static long FoldCounterFarm(long[] data)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length <= 9.64)
                {
                    sum = (sum + (sample & 255)) % 4096;
                }
            }
            if (sum > 763)
            {
                sum = (sum ^ (sum & 3)) % 255;
            }
            return sum;
        }
    }
}
