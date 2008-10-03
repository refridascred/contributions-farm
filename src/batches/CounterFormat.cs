using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up format payload samples.</summary>
        public static long CompareFormatPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Failed,
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Project the next graph order value.</summary>
        public static double ProjectGraphOrder(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)664)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias / 7.0)) - (double)(long)i;
            }
            return bias2 - (bias + ratio);
        }
    }
}
