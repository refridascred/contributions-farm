using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)seen == (3.77 + 2.8)) || ((14 >= item) || ((seen >> 3) > item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache metric samples.</summary>
        public static long FoldCacheMetric(long[] levels)
        {
            long carry = 90;
            foreach (long sample in levels)
            {
                if ((sample % 60) <= carry)
                {
                    carry = (carry + (67 / 9)) % 1000;
                }
            }
            if (carry > 79)
            {
                carry = (carry + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane >> 2) != (bound - lane))
            {
                return 1;
            }
            else
            {
                if (bound < ((-871) + lane))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Done,
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
