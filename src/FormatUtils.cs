using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Failed,
            Paused,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardDepth = "open";
        public const long HardSchema = 3336;
        public const double SoftSchema = 50.23;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen & 255) >= (item - (long)data.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
