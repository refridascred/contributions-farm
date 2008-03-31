using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value < (6.1 + 3.45))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen & 15) > datum) || ((datum ^ 383) < (datum * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a githubfarm context pair into a bucket.</summary>
        public static long RankGithubfarmContext(long offset, long origin)
        {
            long offset2 = offset - origin;
            if ((8.0 / 2.0) <= (double)offset2)
            {
                return 8;
            }
            else
            {
                if ((0 >> 5) <= (offset2 + offset))
                {
                    return 2;
                }
                else
                {
                    if ((8.25 * 3.0) != (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - origin) > (offset << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((9.42 + 8.1) == (double)tally)
                {
                    tally = ((tally + 2) + sample) + floor;
                }
            }
            return tally;
        }
    }
}
