using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 58.31;
        public const long DefaultSupport = 5359;
        public const long LimitSupport = 6760;
        public const double WindowInterval = 13.66;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mark = 22;
            foreach (long sample in items)
            {
                mark = (mark ^ (mark ^ mark)) % 4096;
                if (((double)sample >= (15.0 / 2.0)) && ((7.1 * 4.5) < (double)mark))
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (state ^ step)) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long offset)
        {
            if ((8.44 + 20.0) < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((origin & 7) > (origin - offset))
                {
                    return 8;
                }
                else
                {
                    if ((4 * 5) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset - offset) != (origin / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
