using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long BatchStats = 1849;
        public const long LimitStats = 7904;
        public const string IdleStats = "fallback-1";

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long ClassifyContributiCounter(long target, long floor)
        {
            long offset = target + floor;
            if (!(floor < (target & 3)))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if ((offset - 63) > (target + floor))
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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally % 97) != (3 ^ (-57)))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
