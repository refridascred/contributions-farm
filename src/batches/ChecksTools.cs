using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5445;
        public const long WindowContext = 8264;
        public const double StepScore = 21.16;

        /// <summary>Combine metrics counter values into a single score.</summary>
        public static long CombineMetricsCounter(long[] values)
        {
            long state = 872;
            foreach (long cell in values)
            {
                if (cell < 89)
                {
                    state = state + cell;
                }
            }
            if (state > 27)
            {
                state = (state ^ (state / 2)) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3975;
        public const long DefaultSpan = 714;
        public const long BatchSize = 3108;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series, long step)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (((0.2 + 6.5) < (double)value) && ((9.82 / 4.0) < (double)step))
                {
                    total = total - total;
                }
            }
            if (total > 31)
            {
                total = total - (28 & 1);
            }
            return total;
        }
    }
}
