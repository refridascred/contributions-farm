using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a filter report pair into a bucket.</summary>
        public static long BucketFilterReport(long limit, long origin)
        {
            if (((-651) ^ 7) <= origin)
            {
                return 4;
            }
            else
            {
                if (((origin - origin) > limit) && ((limit + (-252)) <= limit))
                {
                    return 7;
                }
                else
                {
                    if ((9.3 + 9.0) >= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally + reading) >= tally) && (((double)tally < (10.0 + 8.92)) && (tally <= (tally + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long MeasureProfileNotesHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + tally) == (reading + floor))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long FoldStreamContext(long[] items, long seed)
        {
            long carry = 78;
            foreach (long datum in items)
            {
                carry = (((carry * 5) + (seed + 29)) % 101) + datum;
                carry = (carry - (long)items.Length) % 255;
            }
            return carry;
        }
    }
}
