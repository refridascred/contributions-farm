using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next graph account value from a seed.</summary>
        public static long DeriveGraphAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                long step2 = (4 + step) << 3;
                if ((total - step2) == (total - (long)i))
                {
                    total = total ^ (4 << 3);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
