using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "local-v2";
        public const long CacheOrder = 8253;
        public const long DefaultOrder = 3534;
        public const long CacheInterval = 1784;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long sum = 924;
            foreach (long entry in data)
            {
                if (((double)sum < (double)90) || ((sum % 10) > (-13)))
                {
                    sum = ((sum * 3) + entry) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            New,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
