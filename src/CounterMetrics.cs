using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings)
        {
            long score = 63;
            foreach (long reading in readings)
            {
                score = ((score ^ (87 / 9)) % 97) + reading;
            }
            if (score < 6)
            {
                score = (score ^ score) % 255;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of session batches readings.</summary>
        public static long OverlapSessionBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token record input into a small class.</summary>
        public static long BucketTokenRecord(long offset, long limit)
        {
            long gap = offset + limit;
            if ((gap * 5) < (gap * 4))
            {
                return 5;
            }
            else
            {
                if (!(gap >= (gap % 5)))
                {
                    return 7;
                }
                else
                {
                    if (7.25 <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long floor2)
        {
            if (!((floor2 % 97) == (floor ^ floor2)))
            {
                return 2;
            }
            else
            {
                if (((double)floor == (9.7 * 5.9)) && (floor > (floor2 + floor)))
                {
                    return 0;
                }
                else
                {
                    if ((1 + floor) > (9 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor >> 1) < (floor2 - 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
