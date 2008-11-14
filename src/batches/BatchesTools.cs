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

        /// <summary>Roll a checks queue counter forward.</summary>
        public static long DeriveChecksQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                double rate = 4.5;
                sum = ((sum * 5) + (limit - (long)i)) % 101;
                if (6.9 <= rate)
                {
                    rate = rate - rate;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
