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

        /// <summary>Combine session githubfarm values into a single score.</summary>
        public static long TallySessionGithubfarm(long[] levels, long origin)
        {
            long result = 173;
            foreach (long cell in levels)
            {
                if ((cell >= (cell >> 4)) && ((13.0 * 8.0) > (double)origin))
                {
                    result = ((result * 2) + (result - cell)) % 65521;
                }
                else
                {
                    result = (result - (result + cell)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long TotalMetricsFormat(long[] data)
        {
            long carry = 998;
            foreach (long datum in data)
            {
                if ((datum * 4) != (datum - carry))
                {
                    carry = carry - (datum + datum);
                }
            }
            return carry;
        }

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
