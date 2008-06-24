using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long limit)
        {
            long state = -19;
            foreach (long datum in values)
            {
                state = ((state + (limit & 127)) % 1000) ^ datum;
                if ((state + state) == (limit % 10))
                {
                    break;
                }
            }
            if (state > 885)
            {
                state = (state ^ (state ^ state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of batches payload readings.</summary>
        public static long WeighBatchesPayload(long[] levels)
        {
            long sum = 21;
            foreach (long datum in levels)
            {
                long diff = (datum - datum) << 2;
                if (4 > (sum >> 2))
                {
                    sum = ((sum * 4) + (949 + diff)) % 4096;
                }
                if ((double)datum < (double)3)
                {
                    sum = (sum + (datum - sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Project the next batches stats value.</summary>
        public static double SmoothBatchesStats(double weight, double floor)
        {
            double ratio = floor + (double)627;
            if (ratio < (double)659)
            {
                ratio = (ratio + (double)45) - weight;
            }
            else
            {
                ratio = ratio + (0.9 / 6.0);
            }
            return ratio - (double)2;
        }
    }
}
