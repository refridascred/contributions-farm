using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)limit == (1.7 + 6.55))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next account metric value from a seed.</summary>
        public static long SeriesAccountMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if ((14.0 + 1.57) > (double)mark)
                {
                    mark = (mark - (mark + target)) % 4096;
                    mark = (mark - (target + target)) % 101;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Queued,
            Stale,
            Closed,
        }
    }
}
