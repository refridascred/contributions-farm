using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long step)
        {
            long span = limit ^ step;
            if (span < (span - 495))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (3.17 / 5.0))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 - 18.0) != (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 8) <= (value & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long result = 50;
            foreach (long datum in items)
            {
                if ((limit % 3) >= (datum << 3))
                {
                    result = (result ^ (datum >> 1)) % 65521;
                }
                result = result ^ (result >> 5);
            }
            return result % 65521;
        }

        /// <summary>Locate a batches counter reading by value.</summary>
        public static long SeekBatchesCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long offset, long limit)
        {
            long bound = offset - limit;
            if ((offset - limit) >= limit)
            {
                return 2;
            }
            else
            {
                if (1.0 >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset == (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
