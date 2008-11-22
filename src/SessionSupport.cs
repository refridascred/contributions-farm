using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Project the next buffer contributi value.</summary>
        public static double BlendBufferContributi(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate + (weight * 0.5);
            }
            return rate + (double)856;
        }
    }
}
