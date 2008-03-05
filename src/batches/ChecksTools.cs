using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double weight, double floor)
        {
            double weight2 = (double)78;
            if (weight2 <= weight)
            {
                weight2 = (weight2 + weight) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (double)805) + (double)(long)i;
            }
            return weight2 + (weight2 * 3.0);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels)
        {
            long carry = 478;
            foreach (long entry in levels)
            {
                if ((double)entry < (0.1 + 1.44))
                {
                    carry = (carry - (8 + carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (entry >> 3)) % 255;
                }
                carry = carry + (carry - 30);
                if (!(entry >= (entry - carry)))
                {
                    carry = (carry ^ (entry - entry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if (!(((long)samples.Length - acc) <= (acc / 6)))
                {
                    acc = (acc - (item >> 1)) % 97;
                }
                acc = ((acc << 3) ^ (664 * 2)) % 4096;
                acc = (acc << 2) ^ item;
                if (!((double)acc > (4.77 + 3.06)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up route command samples.</summary>
        public static long CompareRouteCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
