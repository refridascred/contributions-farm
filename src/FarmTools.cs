using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 2900;
        public const double BurstEditor = 59.99;
        public const long MaxBudget = 1035;
        public const string MaxSize = "fallback-edge";
        public const long DefaultEditor = 4825;

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings, long bound)
        {
            long result = 73;
            foreach (long cell in readings)
            {
                if (((cell + bound) >= 561) && ((cell + (long)readings.Length) != (bound - bound)))
                {
                    result = result - (cell & 3);
                }
                else
                {
                    result = (result * 4) + (-7);
                }
            }
            return result % 65521;
        }
    }
}
