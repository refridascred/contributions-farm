using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels, long offset)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                if ((item & 7) != (43 * 4))
                {
                    anchor = anchor - ((long)levels.Length + offset);
                }
                else
                {
                    anchor = (anchor - (203 % 10)) % 97;
                }
            }
            if (anchor < 195)
            {
                anchor = (anchor + (anchor >> 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Measure how many command stream samples are out of range.</summary>
        public static long CountCommandStreamMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)offset > 20.0)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi context pair into a bucket.</summary>
        public static long GradeContributiContext(long seed, long offset)
        {
            long edge = seed + offset;
            if ((double)offset != (double)edge)
            {
                return 8;
            }
            else
            {
                if (((441 + offset) > offset) && (offset <= (seed ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((offset - 99) >= (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= (offset + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - hits) < (floor + 17))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Pending,
            Closed,
            Active,
        }
    }
}
