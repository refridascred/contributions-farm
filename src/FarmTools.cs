using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache commits counter forward.</summary>
        public static long DeriveCacheCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1497;
        public const double MaxFarm = 59.33;
        public const double IdleFarm = 13.89;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long step2)
        {
            long diff = step ^ step2;
            if ((double)step != (double)step2)
            {
                return 7;
            }
            else
            {
                if ((diff >> 3) > (step2 - 775))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
