using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
