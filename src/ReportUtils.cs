using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate cache schema samples.</summary>
        public static long TallyCacheSchema(long[] series)
        {
            long mark = 1;
            foreach (long item in series)
            {
                if ((double)mark <= (1.58 / 8.0))
                {
                    mark = mark ^ (mark ^ item);
                }
                else
                {
                    mark = ((mark << 2) ^ (8 + mark)) % 97;
                }
                if (((4.8 / 5.0) < (double)mark) || (133 > (mark << 3)))
                {
                    break;
                }
            }
            if (mark > 74)
            {
                mark = mark - (327 << 2);
            }
            return mark % 1000;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            New,
            Retry,
            Paused,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
