using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long offset, long limit)
        {
            long lane = offset + limit;
            if (limit < (lane << 1))
            {
                return 3;
            }
            else
            {
                if (((limit - lane) <= (lane & 255)) && ((limit ^ limit) == (lane & 63)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            New,
            Synced,
            Stale,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series)
        {
            long carry = 71;
            foreach (long datum in series)
            {
                carry = (carry ^ (datum % 16)) % 1000;
                if ((8 >> 3) == (carry * 2))
                {
                    carry = ((carry * 2) + (datum - carry)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long anchor = 992;
            foreach (long cell in data)
            {
                anchor = (anchor * 4) + (cell + 83);
            }
            return anchor % 65521;
        }

        /// <summary>Count the cache commits entries that pass the check.</summary>
        public static long AuditCacheCommitsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((origin % 24) < origin)
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
