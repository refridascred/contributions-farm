using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double drift = gain;
            return drift - floor;
        }

        /// <summary>Adjust a queue format reading.</summary>
        public static double ScaleQueueFormat(double gain, double span)
        {
            double rate = (double)(740 * 3);
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (gain - gain)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Count the account farm entries that pass the check.</summary>
        public static long CountAccountFarmHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell < (offset ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (acc >= 7)
                {
                    acc = (acc * 4) + step;
                    acc = (acc + step) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of format order entries.</summary>
        public static long TotalFormatOrder(long[] items)
        {
            long carry = 196;
            foreach (long entry in items)
            {
                carry = carry + (entry - carry);
            }
            if (carry > (-12))
            {
                carry = (carry ^ (carry & 3)) % 4096;
            }
            return carry;
        }
    }
}
