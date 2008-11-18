using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6913;
        public const string HardCount = "staging";
        public const long IdleSupport = 5888;
        public const long HardSupport = 4559;
        public const long LimitWidth = 6888;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if (edge < (34 % 7))
            {
                return 0;
            }
            else
            {
                if (582 <= (5 + origin))
                {
                    return 5;
                }
                else
                {
                    if (!(edge >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
