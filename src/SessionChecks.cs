using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long seed)
        {
            long total = 15;
            foreach (long item in series)
            {
                if ((2.62 * 3.28) > (double)total)
                {
                    total = ((total - (67 << 1)) % 97) + item;
                }
                if (seed < (seed & 31))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (origin > 6)
                {
                    mark = ((mark * 5) + (3 << 3)) + sample;
                }
            }
            if (mark < 510)
            {
                mark = (mark << 3) ^ (mark & 7);
            }
            return mark;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - target) <= (625 + target))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "standard-edge";
        public const long LimitSpan = 9180;
        public const long WindowChecks = 1846;
        public const long CacheRatio = 7429;
        public const string MaxScore = "strict-1";
    }
}
