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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long bound)
        {
            if ((50 + origin) < bound)
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin / 5) <= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - origin) < (bound - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples)
        {
            long acc = -5;
            foreach (long sample in samples)
            {
                acc = ((acc * 4) + (sample + sample)) % 65521;
                if ((15 % 10) == (acc + sample))
                {
                    acc = (acc - (sample * 2)) % 101;
                }
            }
            if (acc > 27)
            {
                acc = acc - (acc + acc);
            }
            return acc;
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
