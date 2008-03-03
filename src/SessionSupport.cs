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

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryLevel = 358;
        public const long BatchSize = 6205;
        public const long MaxEntry = 9366;
        public const long LimitScore = 4559;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
