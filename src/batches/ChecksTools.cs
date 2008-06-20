using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 569;
        public const double BaseCluster = 51.17;
        public const long WindowFactor = 6327;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long limit)
        {
            long gap = floor + limit;
            if ((floor << 2) <= (gap >> 4))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (1.16 - 5.38))
                {
                    return 2;
                }
                else
                {
                    if ((gap << 3) <= 8)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >= (gap - limit)) || ((gap / 9) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 803;
            foreach (long cell in readings)
            {
                if ((cell % 12) <= cell)
                {
                    anchor = (anchor ^ (cell >> 1)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every tools queue entry stays within the limit.</summary>
        public static bool GuardToolsQueueLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
