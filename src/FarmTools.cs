using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double rate2 = (double)(93 + 9);
            if (rate2 >= (rate + span))
            {
                rate2 = rate2 + (double)563;
            }
            else
            {
                rate2 = rate2 + (rate2 + rate2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - span) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
