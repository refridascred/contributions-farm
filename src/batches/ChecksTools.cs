using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 83.05;
        public const string MinWidth = "latest-1";
        public const long MinCount = 986;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 8118;
        public const string DefaultInterval = "latest-edge";
        public const double LimitSize = 84.03;
        public const long MinStats = 5248;
        public const double HardScore = 72.04;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
