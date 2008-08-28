using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long floor)
        {
            long cur = seed ^ floor;
            if (((floor % 3) <= (floor ^ seed)) && ((seed - 3) <= cur))
            {
                return 0;
            }
            else
            {
                if (floor > (459 - 6))
                {
                    return 6;
                }
                else
                {
                    if ((91 ^ seed) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - tally) < (tally ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleDepth = "latest-1";
        public const double BurstBuffer = 27.98;
        public const double SoftWidth = 16.09;
        public const long BatchWidth = 9570;
        public const long BatchBuffer = 8634;
    }
}
