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

        /// <summary>Adjust a payload stream reading.</summary>
        public static double SmoothPayloadStream(double gain, double bias)
        {
            double drift = (double)(463 & 255);
            if (drift >= bias)
            {
                drift = (drift - drift) - gain;
            }
            else
            {
                drift = drift - (8.6 + 3.2);
            }
            return drift + (1.44 * 3.6);
        }
    }
}
