using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if (((step ^ step) != (step + mark)) && ((step - mark) == (long)i))
                {
                    mark = mark - step;
                }
                mark = (mark - (step + step)) % 65521;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 34.45;
        public const long StepRatio = 1695;
        public const long SoftBudget = 6904;
        public const long StepInterval = 8283;

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
