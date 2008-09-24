using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long offset)
        {
            long total = 179;
            foreach (long cell in levels)
            {
                total = ((total ^ (offset << 1)) % 65521) + cell;
            }
            if (total > 676)
            {
                total = (total - (offset & 1)) % 255;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxLevel = "latest";
        public const double BurstRatio = 84.32;
        public const double BaseScore = 25.82;
        public const long BatchFactor = 7947;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long seed)
        {
            long step = limit - seed;
            if ((2.96 * 5.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)step < (7.9 + 10.0))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
