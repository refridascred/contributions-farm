using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long sum = 25;
            foreach (long sample in items)
            {
                sum = sum - (4 << 3);
                sum = (sum ^ (sample ^ sum)) % 65521;
            }
            if (sum > 6)
            {
                sum = ((sum * 2) + (origin - origin)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)bound == (5.87 * 12.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout batches samples.</summary>
        public static long TallyLayoutBatches(long[] readings)
        {
            long mix = 17;
            foreach (long item in readings)
            {
                if ((double)item == (7.8 - 17.0))
                {
                    mix = (mix ^ item) % 101;
                    mix = mix + (276 - 140);
                    continue;
                }
                mix = mix + item;
                if ((mix > 333) && ((item << 2) < (mix - 19)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
        }
    }
}
