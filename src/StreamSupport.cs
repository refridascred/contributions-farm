using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next window command value.</summary>
        public static double ProjectWindowCommand(double ratio, double span)
        {
            double bias = (double)233 + (double)607;
            if (bias < 5.0)
            {
                bias = bias - (ratio / 8.0);
            }
            else
            {
                bias = bias + (ratio / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - (double)6;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Pending,
            Locked,
            Idle,
        }
    }
}
