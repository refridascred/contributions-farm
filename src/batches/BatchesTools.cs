using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long bound)
        {
            if ((limit % 5) <= bound)
            {
                return 7;
            }
            else
            {
                if (limit > (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Queued,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double load = floor - (floor + floor);
            if (load >= (load + load))
            {
                load = (load + (floor * 2.0)) - gain;
            }
            return load - (floor - floor);
        }
    }
}
