using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series, long offset)
        {
            long state = 544;
            foreach (long item in series)
            {
                if (!((offset / 3) != (761 % 8)))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state << 3) ^ 11;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowTimeout = "open-v2";
        public const double HardScore = 45.49;
        public const double IdleGraph = 90.4;
        public const string SoftRatio = "open";
        public const long DefaultBudget = 3578;
    }
}
