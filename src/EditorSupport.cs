using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long target)
        {
            long gap = offset + target;
            if (((13.0 * 1.98) <= (double)gap) && (offset < 3))
            {
                return 5;
            }
            else
            {
                if ((gap + target) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((3.41 - 4.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if (!(4 > (anchor + datum)))
                {
                    anchor = ((anchor - (anchor / 4)) % 4096) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context order value from a seed.</summary>
        public static long SeriesContextOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long count = (result + limit) >> 5;
                result = (result << 3) ^ (count + count);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length >= (8.6 - 9.22))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit channel queue readings against a rule.</summary>
        public static long MeasureChannelQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((0.8 + 3.29) > (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
