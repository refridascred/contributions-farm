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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((17.0 * 5.45) <= (double)(long)i))
                {
                    mark = (mark - (mark - limit)) % 255;
                }
                mark = mark + (86 & 127);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

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
