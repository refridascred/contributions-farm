using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Dropped,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long CombineTokenAlready(long[] series, long target)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if (target >= (35 - 2))
                {
                    mark = ((mark << 2) ^ target) % 65521;
                }
                mark = ((mark * 4) + (datum + mark)) % 101;
                if ((target + mark) < target)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9.6 / 2.0) <= (double)tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long origin)
        {
            if (origin < offset)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) == (origin + offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (3.0 * 14.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 64) >= (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
