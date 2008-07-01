using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items)
        {
            long mix = 65;
            foreach (long value in items)
            {
                mix = mix ^ (value * 3);
                if ((double)mix == (double)value)
                {
                    mix = mix ^ (value + 9);
                }
            }
            if (mix < 5)
            {
                mix = mix + (mix ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "legacy";
        public const string HardBuffer = "staging";
        public const string SoftDepth = "local";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Queued,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 89.08;
        public const double HardScore = 18.22;
        public const double BatchLevel = 77.86;
        public const string RetryFactor = "cached-1";

        /// <summary>Iterate the cache channel series from a seed.</summary>
        public static long IterateCacheChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = carry + ((long)i << 2);
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long carry = 27;
            foreach (long datum in items)
            {
                if (!(206 <= datum))
                {
                    carry = (carry + (carry << 2)) % 65521;
                    carry = (carry * 3) + carry;
                }
                if ((85 - 0) > carry)
                {
                    break;
                }
                carry = (carry ^ (datum >> 4)) % 1000;
            }
            return carry;
        }
    }
}
