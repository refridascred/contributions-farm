using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long MeasureCacheEditorMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen < (datum + seed))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long acc = -52;
            foreach (long cell in samples)
            {
                if ((cell + acc) >= (acc * 5))
                {
                    acc = ((acc << 3) ^ cell) % 65521;
                }
                acc = (acc << 3) ^ (acc - acc);
            }
            if (acc < 37)
            {
                acc = (acc * 2) + (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultScore = 48.44;
        public const long MinContributi = 3855;
        public const double MaxContributi = 16.64;
        public const double LimitContributi = 79.77;
    }
}
