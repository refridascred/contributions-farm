using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (step % 8);
                carry = (carry << 2) ^ (251 - (long)i);
                carry = (carry + step) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long TallyRouteAccount(long[] levels, long seed)
        {
            long sum = 388;
            foreach (long datum in levels)
            {
                sum = (sum - (sum + datum)) + seed;
            }
            return sum;
        }

        /// <summary>Scale a contributi report figure with a bias.</summary>
        public static double AdjustContributiReport(double scale, double offset)
        {
            double bias = (double)(541 >> 4);
            if (bias <= (bias + bias))
            {
                bias = (bias - (double)13) - scale;
            }
            else
            {
                bias = bias - (offset - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)0;
        }
    }
}
