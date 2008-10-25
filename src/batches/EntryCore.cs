using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long offset2)
        {
            if ((offset * 4) >= offset2)
            {
                return 4;
            }
            else
            {
                if (((offset / 4) == ((-5) + offset2)) && (offset < (162 + offset2)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 2) ^ (mark + (long)i);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
