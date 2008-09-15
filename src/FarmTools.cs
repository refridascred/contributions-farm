using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen > (4.56 * 17.0))
                {
                    seen = ((seen + 1) + entry) - floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target <= (double)carry) || (carry < ((long)i ^ target)))
                {
                    carry = carry + ((long)i + 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double weight, double span)
        {
            double load = 2.6 - span;
            return (load + load) + weight;
        }
    }
}
