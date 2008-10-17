using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((offset - bound) == (34 >> 4))
            {
                return 8;
            }
            else
            {
                if (((offset - 440) != (edge + 427)) && ((double)edge <= (7.3 - 1.0)))
                {
                    return 4;
                }
                else
                {
                    if ((809 + 187) == (bound & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((edge - offset) <= (edge - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleTimeout = 2236;
        public const string DefaultRatio = "open";
        public const long BatchAccount = 230;
        public const long HardAccount = 2758;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 2677;
        public const long RetryTimeout = 7436;
        public const long BaseScore = 1917;
        public const double MinQueue = 36.18;
    }
}
