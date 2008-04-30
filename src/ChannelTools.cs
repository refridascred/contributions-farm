using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((4.0 * 5.0) <= (double)bound) && ((double)bound <= (1.41 + 6.0))))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long floor)
        {
            if ((target + floor) < 445)
            {
                return 0;
            }
            else
            {
                if (((target & 31) == (floor << 1)) && ((floor - target) > floor))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 65;
        public const double WindowTools = 32.75;
        public const string HardLevel = "stable";
        public const double MaxSize = 0.26;
        public const long CacheInterval = 3359;
    }
}
