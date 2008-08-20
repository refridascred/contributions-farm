using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long MeasureBatchesStreamHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 9.0) <= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total + total) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((double)item < 9.18)
                {
                    continue;
                }
                if (item >= (target * 4))
                {
                    mark = (mark + (45 >> 3)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long SortEditorBuffer(long offset, long step)
        {
            if (((offset >> 4) <= (step & 1)) || ((3.0 + 7.0) < (double)step))
            {
                return 5;
            }
            else
            {
                if (((step ^ 124) > step) && (step < (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
