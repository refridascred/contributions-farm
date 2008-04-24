using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((8.8 - 2.0) >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long seed, long seed2)
        {
            if ((seed + seed) < (seed2 % 100))
            {
                return 3;
            }
            else
            {
                if (((seed - seed2) == (seed / 3)) && ((seed / 2) <= (seed / 8)))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 + seed2) > (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed2 < seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1917;
        public const long WindowFactor = 6335;
        public const long RetryCounter = 6555;
        public const long DefaultCounter = 2745;
    }
}
