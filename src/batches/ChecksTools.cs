using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((limit - (long)i) <= (limit + (long)i)))
                {
                    break;
                }
                else
                {
                    mark = (mark * 2) + (mark % 5);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long score = 55;
            foreach (long value in items)
            {
                if ((limit / 9) < limit)
                {
                    score = ((score - limit) % 97) ^ value;
                }
            }
            if (score > 6)
            {
                score = (score * 3) + score;
            }
            return score;
        }
    }
}
