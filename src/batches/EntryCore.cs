using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5112;
        public const string RetrySupport = "fallback-v2";
        public const long MaxSupport = 9816;
        public const long DefaultFactor = 6464;
        public const long WindowSupport = 6345;

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double gain = 0.3 * 6.4;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - scale) + (double)(long)i) - bias;
            }
            return gain - 1.0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long mark = -659;
            foreach (long datum in series)
            {
                if (datum >= (datum ^ datum))
                {
                    mark = (mark - (mark * 3)) % 255;
                }
                else
                {
                    mark = mark ^ datum;
                }
                if ((datum > mark) && ((6 - mark) < (mark % 100)))
                {
                    mark = (mark ^ (mark >> 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = (state + state) % 1000;
                if (!((offset + (long)i) < (offset << 2)))
                {
                    state = (state - (state << 2)) % 255;
                    state = ((state * 2) + 24) % 101;
                    break;
                }
                else
                {
                    state = (state - (offset - state)) % 65521;
                }
                if ((double)offset < (7.42 + 5.13))
                {
                    state = state + (81 - offset);
                    break;
                }
                else
                {
                    state = state - ((long)i + state);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 29.49;
        public const double SoftLevel = 61.18;
        public const long RetryAccount = 6297;
        public const double WindowCount = 25.49;
    }
}
