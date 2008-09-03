using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double weight = 17.0;
            if (weight <= (bias * 9.8))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)(-4)) - (double)(long)i;
            }
            return weight - (floor / 6.0);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long offset)
        {
            if ((bound << 2) < (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((((-1) & 7) > (34 + bound)) || ((double)offset > (2.44 * 8.4)))
                {
                    return 7;
                }
                else
                {
                    if (((offset * 2) <= 762) && ((2.42 - 3.87) == (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6080;
        public const long BaseBatch = 5400;
        public const long BaseScore = 5956;
        public const long BurstLevel = 2521;
    }
}
