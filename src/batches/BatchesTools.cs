using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 857;
            foreach (long datum in levels)
            {
                result = result - (result - datum);
            }
            return result % 65521;
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
