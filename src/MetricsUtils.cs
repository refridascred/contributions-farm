using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit checks cluster readings against a rule.</summary>
        public static long MeasureChecksClusterGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < 7.2)
                {
                    tally = ((tally + 1) - datum) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a route commits reading by value.</summary>
        public static long SeekRouteCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a farm graph pair into a bucket.</summary>
        public static long BucketFarmGraph(long origin, long offset)
        {
            if (323 > (origin % 3))
            {
                return 3;
            }
            else
            {
                if (((-702) ^ 54) <= origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (10.0 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + offset) != (3 + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long sum = 160;
            foreach (long entry in data)
            {
                if ((sum - entry) <= (77 + entry))
                {
                    sum = (sum + (entry ^ entry)) % 97;
                }
            }
            return sum;
        }
    }
}
