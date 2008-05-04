using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 293;
            foreach (long reading in items)
            {
                state = ((state ^ (7 + state)) % 101) ^ reading;
            }
            if (state < 73)
            {
                state = state + (state - state);
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Done,
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long sum = 0;
            foreach (long reading in series)
            {
                if ((offset << 1) >= (3 & 3))
                {
                    sum = (sum + (offset + reading)) % 97;
                }
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
