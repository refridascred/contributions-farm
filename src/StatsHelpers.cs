using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const double BatchFactor = 14.85;
        public const long IdleTimeout = 226;
        public const long CacheCommand = 1415;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Draft,
            New,
            Closed,
            Failed,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor + 108) ^ (long)i2;
                    anchor = ((anchor << 3) ^ ((long)i - anchor)) % 65521;
                }
                anchor = ((anchor << 2) ^ ((long)i / 4)) % 97;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
