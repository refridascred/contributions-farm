using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)floor == (double)total)
                {
                    total = (total - ((long)i % 7)) % 255;
                }
                if ((total > (floor + floor)) && (floor > (long)i))
                {
                    total = (total * 4) + ((long)i ^ (-88));
                }
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long GradeFarmCommand(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((7.0 + 3.2) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((139 - bound) == (bound2 - gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
