using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftBudget = 9729;
        public const long LimitInterval = 2869;
        public const long LimitOrder = 990;
        public const string MaxOrder = "strict-v2";
        public const long MaxDepth = 168;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum > (seen << 3)) || ((0 + origin) == (origin / 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if ((bound * 5) >= bound)
                {
                    mark = (mark + (sample - mark)) % 1000;
                }
            }
            if (mark < 84)
            {
                mark = mark - (bound % 5);
            }
            return mark;
        }
    }
}
