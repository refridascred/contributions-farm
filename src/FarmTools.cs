using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "stable";
        public const long RetryStream = 6859;
        public const long RetryLevel = 8872;
        public const long IdleDepth = 5794;
        public const string MinDepth = "open-1";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
