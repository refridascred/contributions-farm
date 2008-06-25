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

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings, long target)
        {
            long carry = 509;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (661 & 3)) % 1000;
                if ((target - datum) < (datum % 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Synced,
            Active,
        }
    }
}
