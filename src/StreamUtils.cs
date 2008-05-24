using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((datum + seen) > (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long origin)
        {
            long slot = target ^ origin;
            if (slot <= (-649))
            {
                return 1;
            }
            else
            {
                if (target <= (slot - target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if (((sum << 1) > 159) || (((long)samples.Length << 3) != (57 + datum)))
                {
                    sum = (sum * 2) + datum;
                    continue;
                }
                if (datum < (sum * 2))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                else
                {
                    sum = (sum ^ (datum % 97)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long bound)
        {
            long acc = 98;
            foreach (long value in series)
            {
                acc = ((acc + bound) % 65521) ^ value;
            }
            return acc % 4096;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= (limit << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (19 - 8))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
