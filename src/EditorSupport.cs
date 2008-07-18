using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the graph account entries that pass the check.</summary>
        public static long CountGraphAccountMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + 1) > (step << 1))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] levels, long limit)
        {
            long total = 935;
            foreach (long cell in levels)
            {
                if (limit <= (cell & 31))
                {
                    total = (total - 60) % 255;
                }
                else
                {
                    total = ((total * 5) + (limit >> 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches % 60) > (matches >> 2))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Idle,
            Draft,
            Dropped,
        }
    }
}
