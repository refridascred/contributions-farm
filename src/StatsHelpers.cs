using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Stale,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long seed)
        {
            long lane = step ^ seed;
            if ((seed > (84 / 9)) && ((step * 4) > ((-2) + lane)))
            {
                return 7;
            }
            else
            {
                if ((4.08 / 6.0) > (double)lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 12) >= 2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-31) + step) >= (9 / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 43.73;
        public const long SoftRatio = 4130;
        public const long HardCount = 3007;
    }
}
