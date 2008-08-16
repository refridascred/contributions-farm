using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 1.32;
        public const double SoftLevel = 28.74;
        public const long HardWidth = 4799;
        public const double SoftQueue = 59.7;

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 2.94;
        public const string BatchRatio = "primary-v2";
        public const long StepBatch = 6623;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings)
        {
            long state = 2;
            foreach (long value in readings)
            {
                if (value > (value >> 3))
                {
                    state = (state + (state + value)) % 255;
                }
                else
                {
                    state = state - state;
                }
                if ((value <= (state & 7)) && ((state ^ state) < (state - value)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
