using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next account buffer value from a seed.</summary>
        public static long IterateAccountBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((2.0 > (double)anchor) || ((anchor & 15) > ((long)i * 2)))
                {
                    anchor = (anchor - (anchor & 7)) % 1000;
                    anchor = (anchor ^ anchor) % 4096;
                }
                if ((4.78 * 14.0) > (double)origin)
                {
                    anchor = anchor + (anchor + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series)
        {
            long sum = 278;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (sum * 3)) % 1000;
                sum = (sum ^ (cell / 7)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryRatio = 8674;
        public const string BatchMetric = "local-v2";
        public const long MinTimeout = 4799;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinInterval = 8714;
        public const long BurstQueue = 2626;
        public const string BurstSpan = "latest";
    }
}
