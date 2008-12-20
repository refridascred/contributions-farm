using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] levels, long limit)
        {
            long state = 848;
            foreach (long value in levels)
            {
                if ((limit * 4) > limit)
                {
                    state = (state - limit) % 65521;
                }
                if ((value - (long)levels.Length) >= (state + 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "latest-1";
        public const long StepChannel = 8767;
        public const string HardScore = "staging-v2";
    }
}
