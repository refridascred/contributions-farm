using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a layout counter sample.</summary>
        public static long LocateLayoutCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardLevel = 2243;
        public const string LimitFactor = "standard-v2";
        public const long BurstLevel = 3992;
        public const long MinCommits = 5469;
        public const double CacheCommits = 65.84;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
