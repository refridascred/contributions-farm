using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - hits) > cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((31 - 53) <= (reading - seen)) || ((reading >> 5) < (seen + seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks channel entries.</summary>
        public static long TallyChecksChannel(long[] readings)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                carry = (carry - (carry << 3)) % 65521;
                if (!((double)cell != (1.5 / 5.0)))
                {
                    carry = carry - 0;
                }
                if ((cell * 5) <= (carry - (-9)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardWidth = "staging-v2";
        public const long CacheEntry = 943;
        public const long MinSpan = 847;

        /// <summary>Classify a metric editor pair into a bucket.</summary>
        public static long BucketMetricEditor(long bound, long limit)
        {
            if ((4.11 + 8.1) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((84 >> 5) <= (bound ^ limit))
                {
                    return 7;
                }
                else
                {
                    if (((0.8 + 9.6) < (double)limit) || ((limit & 63) >= limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit <= (limit + limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
