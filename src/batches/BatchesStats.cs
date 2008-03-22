using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels, long floor)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                carry = (((carry - (carry * 5)) % 101) - cell) - floor;
                if ((carry / 6) >= (91 / 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long seed)
        {
            if (floor > 79)
            {
                return 7;
            }
            else
            {
                if ((38 - floor) >= (seed >> 1))
                {
                    return 5;
                }
                else
                {
                    if (!((1 % 97) <= (seed & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor != (2.2 / 4.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double bias = (span + span) - (double)1;
            if (bias <= ratio)
            {
                bias = bias + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (span * 0.4);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Draft,
            New,
            Active,
        }
    }
}
