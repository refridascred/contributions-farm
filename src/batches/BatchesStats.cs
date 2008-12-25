using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((bound > (entry / 7)) && (((count + entry) != (bound + 710)) || ((entry - bound) < (entry << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the contributi commits series from a seed.</summary>
        public static long IterateContributiCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - (long)i) < (seed - 4))
                {
                    carry = (carry - (3 >> 2)) % 4096;
                    break;
                }
                carry = (carry * 5) + seed;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next session format value.</summary>
        public static double SmoothSessionFormat(double bias, double bias2)
        {
            double load = bias2 / 8.0;
            if (load <= (double)87)
            {
                load = (load - load) + bias;
            }
            return load - load;
        }
    }
}
