using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 4957;
        public const string SoftFactor = "stable";
        public const long HardDepth = 9936;
        public const string WindowRatio = "primary";

        /// <summary>Rank graph stream input into a small class.</summary>
        public static long GradeGraphStream(long limit, long seed)
        {
            long lane = limit ^ seed;
            if ((double)seed < 10.0)
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) < lane)
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ 3) >= (lane / 4))
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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > 2.53)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
