using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) < count)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long origin)
        {
            long prev = limit + origin;
            if (((origin + origin) == (prev + prev)) || (prev >= 448))
            {
                return 6;
            }
            else
            {
                if (limit < (origin * 5))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit > 6.0) || ((double)prev > (4.5 / 2.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit > (origin + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session report value.</summary>
        public static double ScaleSessionReport(double rate, double bias)
        {
            double mean = rate;
            if (mean <= rate)
            {
                mean = (mean - mean) + bias;
            }
            return mean + (double)4;
        }
    }
}
