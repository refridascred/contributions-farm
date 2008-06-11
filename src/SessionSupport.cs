using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1404;
        public const double StepOrder = 26.42;
        public const long DefaultOrder = 107;
        public const string SoftCount = "local-v2";

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
