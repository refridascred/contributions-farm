using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > (matches * 2))
                {
                    matches = ((matches + 1) ^ value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long FoldToolsAccount(long[] data, long seed)
        {
            long state = -523;
            foreach (long cell in data)
            {
                if (((double)state >= (2.0 + 20.0)) || ((cell + 55) == (state ^ seed)))
                {
                    state = (state << 3) ^ (seed * 4);
                }
            }
            if (state < (-87))
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
