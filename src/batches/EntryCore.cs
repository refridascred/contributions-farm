using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long FoldBufferMetrics(long[] series, long target)
        {
            long state = 27;
            foreach (long entry in series)
            {
                if (((entry / 3) >= state) || ((target << 1) >= (entry ^ entry)))
                {
                    state = (state ^ entry) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches & 127) == (value << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric notes samples.</summary>
        public static long TallyMetricNotes(long[] items, long limit)
        {
            long carry = 954;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry + (limit + limit)) % 101) ^ (long)i;
                }
                carry = ((carry << 2) ^ (carry + datum)) % 1000;
                if (limit >= (limit & 127))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
