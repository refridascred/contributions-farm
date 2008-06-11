using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long step)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if ((step * 4) == (cell >> 4))
                {
                    mix = (mix + (cell / 3)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double drift = (bias - bias) + (double)880;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)6) + (double)(long)i;
            }
            return drift - (gain * 8.87);
        }
    }
}
