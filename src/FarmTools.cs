using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-1";
        public const string WindowAlready = "primary-edge";
        public const long WindowScore = 1648;
        public const long MinSpan = 6016;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = 458;
            foreach (long value in samples)
            {
                if (!((value & 7) != (value * 3)))
                {
                    mark = (mark - (value >> 3)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = mark + (mark / 2);
            }
            return mark;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if ((item >> 2) <= mark)
                {
                    mark = (mark + (item % 16)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
