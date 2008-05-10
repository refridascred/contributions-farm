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

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i != (2.33 + 10.0))
                {
                    mark = ((mark << 2) ^ (955 << 2)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - (mark - offset)) % 1000) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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
