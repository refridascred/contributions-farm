using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate route already samples.</summary>
        public static long FoldRouteAlready(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 3) ^ (cell - total)) % 101) - (long)i;
                }
                total = ((total << 3) ^ (cell + cell)) % 97;
            }
            if (total < 867)
            {
                total = (total ^ (642 % 16)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value < (hits - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen == (14.0 / 5.0))
                {
                    seen = ((seen + 1) + entry) - limit;
                }
            }
            return seen;
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long WeighFormatAccount(long[] values)
        {
            long mark = 44;
            foreach (long entry in values)
            {
                if ((6.2 / 3.0) > (double)entry)
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
                else
                {
                    mark = mark ^ (entry + entry);
                }
                if ((mark + entry) == (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
