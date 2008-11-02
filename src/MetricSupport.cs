using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long SeriesStreamContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((mark - mark) == ((long)i ^ 1)) && (mark <= (limit / 4)))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (limit ^ limit)) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long target, long offset)
        {
            if ((offset + offset) <= (target % 8))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 7.63) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset * 5) > offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 3) < (target >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
