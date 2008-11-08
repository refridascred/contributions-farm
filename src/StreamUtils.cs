using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long CombineClusterCommits(long[] items)
        {
            long mix = 968;
            foreach (long entry in items)
            {
                if ((2.17 + 4.0) < (double)mix)
                {
                    mix = (mix ^ (36 + 3)) - entry;
                }
                else
                {
                    mix = ((mix * 2) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a notes queue reading by value.</summary>
        public static long FindNotesQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long sum = 743;
            foreach (long item in data)
            {
                sum = (((sum << 3) ^ (sum / 9)) % 255) ^ item;
            }
            if (sum < 74)
            {
                sum = (sum - (sum & 15)) % 4096;
            }
            return sum;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
