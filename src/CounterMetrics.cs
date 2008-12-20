using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long carry = 47;
            foreach (long reading in levels)
            {
                if ((12 <= (66 + carry)) || ((55 << 2) >= carry))
                {
                    carry = ((carry + (carry * 5)) % 97) + reading;
                }
            }
            return carry;
        }

        /// <summary>Classify a profile channel pair into a bucket.</summary>
        public static long BucketProfileChannel(long origin, long target)
        {
            if (!((origin * 3) >= target))
            {
                return 7;
            }
            else
            {
                if (((origin + 33) <= (origin >> 2)) && (origin > (400 & 3)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long offset = origin ^ limit;
            if (((limit >> 2) > (origin ^ origin)) || ((limit + origin) > (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((double)origin >= 1.29) && ((offset * 5) == (limit + origin)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset << 1) <= (offset >> 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
