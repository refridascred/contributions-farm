using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 2.64)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long origin)
        {
            long sum = 3;
            foreach (long item in data)
            {
                if ((item * 5) > (sum % 5))
                {
                    sum = sum + 8;
                    continue;
                }
                sum = (sum + (origin & 31)) % 255;
            }
            if (sum > 9)
            {
                sum = (sum - (origin ^ origin)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                if ((limit - limit) == (entry ^ anchor))
                {
                    anchor = (anchor << 2) ^ (12 >> 3);
                }
                anchor = anchor ^ (entry & 127);
            }
            return anchor;
        }
    }
}
