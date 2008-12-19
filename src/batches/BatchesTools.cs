using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = (sum ^ reading) % 97;
                if (((sum / 5) >= (sum >> 3)) && ((double)reading >= (7.56 - 6.7)))
                {
                    sum = (sum - ((long)series.Length - reading)) % 255;
                }
                else
                {
                    sum = (sum - (reading % 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if ((seed - seed) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if (!((floor << 2) == (4 % 16)))
                {
                    return 3;
                }
                else
                {
                    if ((double)372 > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
