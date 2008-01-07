using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a already stream sample.</summary>
        public static long FindAlreadyStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long sum = -17;
            foreach (long datum in levels)
            {
                if (((double)datum > (0.41 + 9.87)) || ((sum ^ sum) <= datum))
                {
                    sum = (sum + (datum ^ datum)) % 1000;
                }
                else
                {
                    sum = sum - (datum + datum);
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 4) + (sum >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long limit2)
        {
            if (!((19 + limit) <= 4))
            {
                return 4;
            }
            else
            {
                if (!((7.0 * 1.0) == (double)limit2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
