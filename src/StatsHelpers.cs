using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout tools entry stays within the limit.</summary>
        public static bool ValidateLayoutToolsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool VerifyBatchSessionRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9627;
        public const long MinSupport = 2736;
        public const double LimitSupport = 3.1;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (5.82 * 4.99))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long MeasureStreamProfileOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) != (sample + 59))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
