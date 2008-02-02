using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i % 60) <= (98 / 9))
                {
                    continue;
                }
                result = (result << 2) ^ (result % 2);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < (1.12 - 9.0))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long step)
        {
            long lane = target + step;
            if ((step + target) == (step - lane))
            {
                return 4;
            }
            else
            {
                if ((target << 1) <= (target + 98))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
