using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double floor)
        {
            double load = (floor + rate) * 7.7;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (7.4 / 2.0)) + (double)(long)i;
            }
            return load + (double)890;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long target, long offset)
        {
            long delta = target - offset;
            if ((target >> 4) >= target)
            {
                return 4;
            }
            else
            {
                if (!((offset >> 3) <= (delta << 1)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
