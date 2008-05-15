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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + seed) % 255;
                if ((seed + 7) == (total + (long)i))
                {
                    total = (total - (seed % 5)) % 255;
                    total = (total + (long)i) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long state = 126;
            foreach (long item in samples)
            {
                if ((item + item) != (item & 1))
                {
                    state = (state + (state & 255)) % 97;
                }
            }
            if (state > (-8))
            {
                state = state ^ (state >> 4);
            }
            return state;
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
