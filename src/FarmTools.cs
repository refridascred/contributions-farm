using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "staging";
        public const long LimitFilter = 5071;
        public const double RetryInterval = 48.95;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((19.0 > (double)hits) || ((double)cell != (double)47))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
