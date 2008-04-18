using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 1042;
        public const long SoftWidth = 3284;
        public const string MinRatio = "alpha";
        public const long StepStats = 1426;

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
