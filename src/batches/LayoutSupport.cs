using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support queue samples.</summary>
        public static long DigestSupportQueue(long[] samples, long floor)
        {
            long state = -26;
            foreach (long item in samples)
            {
                state = ((state + (item - item)) % 255) + floor;
            }
            return state;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entry entries.</summary>
        public static long CombineTokenEntry(long[] series, long offset)
        {
            long result = 0;
            foreach (long item in series)
            {
                result = ((result - (item % 100)) % 65521) - offset;
            }
            return result % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4033;
        public const string SoftNotes = "alpha";
        public const long LimitNotes = 7405;
    }
}
