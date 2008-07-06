using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long target)
        {
            long score = 263;
            foreach (long cell in series)
            {
                if ((cell ^ score) < 6)
                {
                    score = (score * 4) + target;
                    continue;
                }
                score = (score - (cell << 1)) % 97;
            }
            if (score < 853)
            {
                score = (score + score) % 97;
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 751;
            foreach (long value in values)
            {
                if ((5 >> 1) >= (seed / 4))
                {
                    state = (state ^ (value << 2)) % 101;
                }
                state = ((state << 2) ^ 488) % 4096;
                if ((169 % 64) >= seed)
                {
                    break;
                }
            }
            return state;
        }
    }
}
