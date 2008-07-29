using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a counter account pair into a bucket.</summary>
        public static long BucketCounterAccount(long limit, long floor)
        {
            long span = limit + floor;
            if (((double)limit < 8.0) && ((5 + span) > (limit * 3)))
            {
                return 6;
            }
            else
            {
                if ((27 - limit) <= (span & 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (8.2 >= (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((63 - limit) == (hits << 2)) || ((datum + hits) > 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if (2.0 >= (double)acc)
                {
                    acc = acc - offset;
                    acc = ((acc << 3) ^ offset) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Closed,
            New,
        }
    }
}
