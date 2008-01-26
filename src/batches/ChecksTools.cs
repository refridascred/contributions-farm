using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (((8.77 / 8.0) != (double)target) && ((target + (-6)) > (score % 64)))
                {
                    score = ((score << 2) ^ (score / 4)) % 97;
                    score = (score * 3) + (target * 3);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a window route value against two limits.</summary>
        public static long ClassifyWindowRoute(long floor, long limit)
        {
            if ((double)limit >= (8.8 / 5.0))
            {
                return 1;
            }
            else
            {
                if (((double)limit == (4.0 * 1.0)) || ((double)floor > (5.5 + 3.0)))
                {
                    return 3;
                }
                else
                {
                    if (((limit << 2) >= (floor - floor)) || ((floor << 3) > (limit ^ limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
