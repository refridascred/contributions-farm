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

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 64;
        public const long BaseScore = 8373;
        public const double RetryBatch = 95.4;
        public const long LimitBatch = 5502;

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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7468;
        public const string MaxRoute = "stable-1";
        public const string BurstTimeout = "stable-v2";
        public const long HardRoute = 2185;
        public const long IdleRoute = 2011;
    }
}
