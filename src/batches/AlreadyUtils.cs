using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 2.52;
        public const long MinLevel = 4345;
        public const string WindowSupport = "latest-v2";
        public const double BurstFactor = 93.74;
        public const long HardRatio = 6685;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheSpan = 67.98;
        public const string StepContext = "standard";
        public const string LimitContext = "alpha-1";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result << 2) ^ ((long)i2 + (-1));
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
