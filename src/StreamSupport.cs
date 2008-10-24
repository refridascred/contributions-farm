using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardInterval = 8653;
        public const long IdleRoute = 992;
        public const string BatchRoute = "standard-v2";
        public const long WindowRoute = 9212;
        public const long StepRoute = 4620;

        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long GradeEntryCounter(long step, long bound)
        {
            long offset = step - bound;
            if ((double)bound < (6.0 + 6.8))
            {
                return 8;
            }
            else
            {
                if ((offset + bound) >= (-3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data, long target)
        {
            long result = -446;
            foreach (long cell in data)
            {
                result = (result - (result / 6)) % 4096;
                if ((cell << 2) > (cell - result))
                {
                    result = result - (target * 5);
                }
                else
                {
                    result = result ^ 67;
                }
            }
            if (result > 516)
            {
                result = ((result << 2) ^ 3) % 4096;
            }
            return result;
        }
    }
}
