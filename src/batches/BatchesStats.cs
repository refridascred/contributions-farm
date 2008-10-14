using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit window account readings against a rule.</summary>
        public static long TallyWindowAccountHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((item & 255) >= (matches << 1)) && ((double)item >= (double)matches)) && (((4.38 + 12.0) >= (double)item) && ((item - matches) == (item % 5))))
                {
                    matches = (matches + 3) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor route samples.</summary>
        public static long DigestEditorRoute(long[] levels, long origin)
        {
            long mix = -56;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ (mix / 3);
                if ((origin << 2) == (entry * 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long FoldEntryToken(long[] data, long limit)
        {
            long sum = 72;
            foreach (long sample in data)
            {
                if (((double)sample > (0.54 * 15.0)) && ((11.0 + 6.64) <= (double)limit))
                {
                    sum = (sum << 2) ^ (sum + limit);
                }
                else
                {
                    sum = ((sum * 3) + (limit >> 2)) % 101;
                }
                if (7 > (limit + sample))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
