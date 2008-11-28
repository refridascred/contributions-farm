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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen <= (seen & 7)) || ((seen - 817) > (seen / 9))))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
