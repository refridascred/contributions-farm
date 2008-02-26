using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((45 - 50) < (seed >> 2))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double gain2 = 9.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - floor;
            }
            return gain2 - (gain + gain);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
