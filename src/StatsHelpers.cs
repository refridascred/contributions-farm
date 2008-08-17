using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double rate2 = bias / 9.0;
            if (rate2 < 20.0)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 + (bias / 4.0);
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
