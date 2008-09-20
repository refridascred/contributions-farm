using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Paused,
            New,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long step)
        {
            long sum = 0;
            foreach (long item in items)
            {
                if ((19.0 / 5.0) <= (double)item)
                {
                    sum = (sum + (-45)) % 255;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 255;
                    sum = ((sum << 2) ^ (sum - sum)) % 1000;
                }
                if (((12.0 * 8.7) != (double)sum) || (803 >= (item * 4)))
                {
                    sum = (sum ^ (65 % 16)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (step - item);
                }
            }
            if (sum > 3)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Iterate the counter order series from a seed.</summary>
        public static long StepCounterOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (origin > sum)
                {
                    sum = (sum - (origin << 3)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
