using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 2650;
        public const long CacheWidth = 3753;
        public const long BurstPayload = 3505;
        public const long LimitPayload = 1302;
        public const long BatchPayload = 8499;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 909;
        public const long MaxSupport = 3911;
        public const long CacheSupport = 1942;
        public const double MinSupport = 89.16;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 7599;
        public const long BatchCommand = 9413;
        public const double DefaultInterval = 40.95;
        public const long BaseWidth = 6287;
        public const string LimitCommand = "standard-v2";

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
