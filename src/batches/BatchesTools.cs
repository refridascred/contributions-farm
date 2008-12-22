using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (long)i) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double weight = 9.8;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) + floor;
            }
            return weight - (scale / 7.0);
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long next = seed + offset;
            if ((seed << 1) <= (503 >> 1))
            {
                return 3;
            }
            else
            {
                if (next < (seed / 3))
                {
                    return 5;
                }
                else
                {
                    if (((seed & 15) == (next * 4)) || ((seed >> 4) == (offset / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset ^ seed) != (offset - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
