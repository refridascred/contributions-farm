using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxLevel = 57.71;
        public const long BaseChecks = 7499;
        public const long DefaultLevel = 3388;
        public const string MinDepth = "standard-1";

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7965;
        public const double BatchLevel = 43.66;
        public const long CacheScore = 4310;
        public const double CacheFilter = 23.81;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (result + (-8))) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
