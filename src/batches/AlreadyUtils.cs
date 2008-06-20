using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long mark = 281;
            foreach (long value in items)
            {
                if ((mark + mark) >= (value + value))
                {
                    mark = (mark << 2) ^ (value + mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long anchor = 7;
            foreach (long sample in data)
            {
                anchor = (((anchor * 3) + (3 - 57)) % 4096) ^ sample;
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
