using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long offset, long floor)
        {
            if ((offset / 2) == (floor / 3))
            {
                return 2;
            }
            else
            {
                if (!((double)floor != (3.4 + 1.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset + floor) <= (floor & 63))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)seen >= 3.94) || ((origin / 2) > (origin - origin)))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7260;
        public const double SoftMetrics = 43.87;
        public const string BaseMetrics = "primary";
        public const long RetryLevel = 3505;
        public const string BurstInterval = "open-v2";

        /// <summary>Locate a channel notes reading by value.</summary>
        public static long SeekChannelNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
