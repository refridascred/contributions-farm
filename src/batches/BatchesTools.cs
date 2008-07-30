using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowFactor = 7624;
        public const double MaxGraph = 17.28;
        public const string BaseWidth = "local-v2";

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long seed)
        {
            long mark = 541;
            foreach (long entry in samples)
            {
                mark = ((mark ^ ((-30) << 3)) % 65521) + entry;
            }
            if (mark < (-3))
            {
                mark = (mark * 2) + (mark + seed);
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
