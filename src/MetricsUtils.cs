using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (755 < (23 + origin))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data)
        {
            long sum = -839;
            foreach (long reading in data)
            {
                sum = ((sum * 4) + (sum - sum)) + reading;
                if ((9.2 + 6.0) > (double)sum)
                {
                    break;
                }
            }
            return sum % 65521;
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
