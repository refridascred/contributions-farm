using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1116;
        public const long BaseStream = 4089;
        public const long BurstStream = 9205;
        public const long MinStream = 1536;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "legacy-v2";
        public const long HardCount = 6541;
        public const long MinFactor = 9884;
        public const long SoftScore = 5816;
        public const long RetryScore = 2353;

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
