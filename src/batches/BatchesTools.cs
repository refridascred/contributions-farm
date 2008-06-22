using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total - (7 - total)) % 4096;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total ^ (limit * 3)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((offset / 7) < offset2)
            {
                return 6;
            }
            else
            {
                if (!((offset - floor) < floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (offset2 ^ 3)) && ((double)6 != (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset2 >> 4) <= ((-2) ^ offset2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
