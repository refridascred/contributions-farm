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

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long MeasureProfileMetricHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) == (seed + 660))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
