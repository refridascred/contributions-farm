using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((floor / 8) == (68 + 18))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if ((origin + limit) >= origin)
            {
                return 5;
            }
            else
            {
                if ((632 + 488) > (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 3) <= 22) && ((limit ^ limit) == (limit % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((13.0 + 4.69) >= (double)origin) || ((6.94 / 6.0) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] series)
        {
            long mix = 850;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ datum) % 1000;
            }
            return mix;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item - item) == (seen << 3)) && (seen < (item & 15)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
