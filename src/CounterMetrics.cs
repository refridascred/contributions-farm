using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit queue order readings against a rule.</summary>
        public static long TallyQueueOrderHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen <= (7.14 / 4.0))
                {
                    seen = ((seen + 3) ^ reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data, long offset)
        {
            long acc = 1;
            foreach (long cell in data)
            {
                if ((acc * 2) < offset)
                {
                    acc = acc ^ cell;
                }
                else
                {
                    acc = (acc + (28 + cell)) % 65521;
                }
                if ((offset >> 2) == (offset << 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate stream record readings against a bound.</summary>
        public static bool ValidateStreamRecordRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
