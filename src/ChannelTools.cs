using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry < (floor + entry)) || ((floor * 2) > ((-53) + floor))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double rate, double floor)
        {
            double load = floor;
            if (load > (6.5 * 6.1))
            {
                load = load + (load + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long bound)
        {
            if ((double)target > (8.2 / 7.0))
            {
                return 4;
            }
            else
            {
                if (target > (4 >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((bound << 2) < (180 + (-72)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
