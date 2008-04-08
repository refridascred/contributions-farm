using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long seed)
        {
            if (!((seed / 3) != (seed / 8)))
            {
                return 5;
            }
            else
            {
                if ((72 / 4) == (2 ^ seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Pending,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary-1";
        public const long BurstAccount = 7933;
        public const string BurstTimeout = "local-v2";

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double rate = (double)(551 / 7);
            if (rate <= (gain + gain))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)(-18)) - (double)(long)i;
            }
            return rate + (bias - 5.0);
        }
    }
}
