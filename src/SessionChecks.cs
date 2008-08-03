using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 1.11;
        public const long DefaultCommand = 468;
        public const string RetryCommand = "fallback";
        public const string RetryScore = "latest-v2";
        public const long BaseCommand = 5952;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long carry = 2;
            foreach (long reading in series)
            {
                carry = (carry - (carry % 16)) % 97;
                if (((46 & 15) <= (carry + carry)) || (reading > (carry & 15)))
                {
                    carry = carry - (reading / 3);
                }
                else
                {
                    carry = (carry - (carry << 3)) % 1000;
                }
            }
            if (carry > (-477))
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }
    }
}
