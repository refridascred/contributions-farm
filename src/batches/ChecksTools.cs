using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings)
        {
            long carry = 884;
            foreach (long cell in readings)
            {
                carry = ((carry ^ (5 << 3)) % 97) + cell;
                if ((1.0 - 8.0) > (double)carry)
                {
                    carry = carry - (carry >> 3);
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ state) % 1000;
                double rate = (double)(offset + offset);
                if (!(((double)offset >= rate) || (offset <= (offset % 8))))
                {
                    rate = rate + 5.0;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Queued,
            Done,
        }
    }
}
