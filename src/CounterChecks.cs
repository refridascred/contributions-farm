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

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (long)i) % 97;
                total = (total + (total + limit)) % 4096;
                if (limit > (-810))
                {
                    total = (total + (limit + total)) % 97;
                }
                else
                {
                    total = (total + total) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool CheckAlreadySupportBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
