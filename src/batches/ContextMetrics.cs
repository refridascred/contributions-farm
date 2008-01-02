using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of graph support entries.</summary>
        public static long DigestGraphSupport(long[] values, long target)
        {
            long mark = 495;
            foreach (long cell in values)
            {
                mark = (((mark - 253) % 1000) - cell) - target;
            }
            return mark;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long step)
        {
            if (!(step >= (offset % 64)))
            {
                return 7;
            }
            else
            {
                if ((offset + step) < (offset - offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset < (4.4 * 2.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset >> 1) <= (offset + step)) && ((double)offset < (6.48 * 5.0)))
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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length == (2.3 * 9.7))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((step + 99) <= 942))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
