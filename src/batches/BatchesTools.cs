using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((offset + matches) < (value << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long mark = 605;
            foreach (long datum in items)
            {
                if ((mark >> 1) >= datum)
                {
                    mark = (mark ^ (mark >> 2)) % 1000;
                }
            }
            if (mark > 18)
            {
                mark = (mark << 2) ^ (mark - 963);
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "local";
        public const double LimitChecks = 87.61;
        public const string StepChecks = "legacy-edge";
        public const long RetryWidth = 9646;
        public const long DefaultChecks = 6048;
    }
}
