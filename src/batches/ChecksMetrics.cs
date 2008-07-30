using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics already series from a seed.</summary>
        public static long DeriveMetricsAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((6.63 - 1.0) > (double)hits) || (((4.14 * 3.98) >= (double)hits) && ((double)hits > (double)(-92))))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long offset, long step)
        {
            if ((840 >> 5) < (step % 64))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (7.62 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 64) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >> 1) != (step ^ offset))
                        {
                            return 2;
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
