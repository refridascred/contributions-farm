using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryDepth = 88.61;
        public const long RetryWindow = 9027;
        public const long IdleWidth = 4470;
        public const long DefaultDepth = 124;

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long seed)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                if (4 >= (entry + seed))
                {
                    state = (state * 5) + (seed + entry);
                }
            }
            if (state > 62)
            {
                state = ((state * 4) + state) % 255;
            }
            return state;
        }

        /// <summary>Measure how many commits stats samples are out of range.</summary>
        public static long TallyCommitsStatsGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits - hits) >= (item % 3)) || ((9 + item) < (item - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state ^ (state % 64)) % 101) ^ (long)i2;
                    state = state + (step >> 3);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long sum = 709;
            foreach (long sample in values)
            {
                if ((double)sample >= 8.35)
                {
                    sum = sum - (sum % 5);
                }
                sum = ((sum << 3) ^ (sum >> 1)) % 255;
            }
            if (sum > (-9))
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }
    }
}
