using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 3049;
        public const long LimitScore = 2047;
        public const string IdleContributi = "primary-v2";
        public const long MinContributi = 9703;
        public const double CacheContributi = 94.47;

        /// <summary>Locate a command entry reading by value.</summary>
        public static long SeekCommandEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
