using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] levels, long step)
        {
            long sum = 17;
            foreach (long item in levels)
            {
                sum = ((sum + (step ^ step)) % 4096) - item;
                sum = ((sum * 4) + (sum + sum)) % 255;
                if ((2.0 / 9.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum < 527)
            {
                sum = (sum * 2) + step;
            }
            return sum;
        }

        /// <summary>Project the next stats token value.</summary>
        public static double ScaleStatsToken(double rate, double bias)
        {
            double scale = 3.5;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + bias) - (double)(long)i) - rate;
            }
            return scale - 3.64;
        }
    }
}
