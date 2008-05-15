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

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if (!((sample * 3) != (sample + mark)))
                {
                    mark = ((mark * 4) + mark) % 255;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4033;
        public const string SoftNotes = "alpha";
        public const long LimitNotes = 7405;
    }
}
