using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool CheckCounterCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
