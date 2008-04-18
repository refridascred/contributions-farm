using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "latest-edge";
        public const double BaseFactor = 72.01;
        public const double MinPayload = 27.51;
        public const long IdleInterval = 8164;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = (state - (state / 7)) % 101;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
