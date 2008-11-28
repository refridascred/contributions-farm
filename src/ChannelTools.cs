using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "standard-v2";
        public const long MaxSize = 6105;
        public const string StepSpan = "strict";
        public const long SoftRatio = 8795;

        /// <summary>Grade a support checks value against two limits.</summary>
        public static long ClassifySupportChecks(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((bound / 7) > (edge ^ seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (15.0 * 18.0))
                {
                    return 3;
                }
                else
                {
                    if ((edge & 31) <= (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3 >> 2) <= (edge + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a queue window value against two limits.</summary>
        public static long ClassifyQueueWindow(long floor, long origin)
        {
            long prev = floor + origin;
            if (!(771 <= (prev + origin)))
            {
                return 1;
            }
            else
            {
                if ((prev - prev) > (floor - 9))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
