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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long target)
        {
            if ((0 + offset) <= (1 - target))
            {
                return 7;
            }
            else
            {
                if ((offset - 52) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((4.9 + 8.8) >= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target / 9) > (598 - 4)) && (277 > (offset % 97)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
