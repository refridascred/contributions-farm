using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = offset;
            if (drift > bias)
            {
                drift = drift - bias;
            }
            return drift - bias;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Idle,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
