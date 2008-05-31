using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 3519;
        public const string RetryReport = "alpha-v2";
        public const long LimitScore = 4951;

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long seed)
        {
            long mark = 876;
            foreach (long reading in data)
            {
                mark = mark - (seed & 3);
                mark = (mark + (mark ^ reading)) % 4096;
                if ((mark % 97) == (mark / 4))
                {
                    break;
                }
            }
            if (mark < 164)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound * 4) >= mix)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
