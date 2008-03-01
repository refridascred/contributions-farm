using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 8988;
        public const long MinSpan = 7097;
        public const long IdleDepth = 7141;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long floor2)
        {
            if ((6.0 + 1.9) >= (double)floor2)
            {
                return 1;
            }
            else
            {
                if ((floor2 % 60) <= floor2)
                {
                    return 7;
                }
                else
                {
                    if ((floor2 - floor) < (55 & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
