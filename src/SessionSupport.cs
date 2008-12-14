using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((67 * 2) <= count))
                {
                    count = ((count + 2) + item) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "cached";
        public const long MaxBudget = 1044;
        public const string BatchStream = "strict";
        public const long BurstDepth = 9631;
        public const long MaxStream = 3239;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((44 ^ (long)readings.Length) <= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
