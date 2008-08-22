using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long limit)
        {
            if ((step + step) > step)
            {
                return 5;
            }
            else
            {
                if ((7.34 - 8.6) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (((step >> 1) < limit) && ((limit & 1) != (step * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step >= (step / 9)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double load = (double)(597 % 3);
            return ((load + (double)66) + weight) + span;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (5 >= (hits + step))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
