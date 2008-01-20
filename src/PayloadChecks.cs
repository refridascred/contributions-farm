using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank profile schema input into a small class.</summary>
        public static long BucketProfileSchema(long seed, long limit)
        {
            long next = seed + limit;
            if (limit >= (next >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)next != (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((next % 5) == (next + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 2) == (43 << 2))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue format value from a seed.</summary>
        public static long DeriveQueueFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor ^ anchor) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit graph counter readings against a rule.</summary>
        public static long MeasureGraphCounterMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 7) == (count % 10))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 100) <= limit)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((tally + item) <= item) || ((tally ^ tally) >= item)) && ((tally * 4) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
