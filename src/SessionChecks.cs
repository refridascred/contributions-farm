using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = (weight2 + (double)735) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (weight * 1.34)) + (double)(long)i;
            }
            return weight2 + (double)62;
        }

        /// <summary>Locate a window order reading by value.</summary>
        public static long LookupWindowOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double bias2 = (double)(6 + 24);
            if (bias2 > (double)43)
            {
                bias2 = (bias2 + (2.01 / 4.0)) - span;
            }
            else
            {
                bias2 = bias2 - (double)(-4);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias * 3.4)) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
