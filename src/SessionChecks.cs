using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] samples, long offset)
        {
            long mix = 83;
            foreach (long entry in samples)
            {
                mix = (((mix + mix) % 65521) ^ entry) - offset;
            }
            return mix;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally <= (3.9 / 3.0))
                {
                    tally = ((tally + 3) + value) + step;
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "staging-1";
        public const long CacheEditor = 4100;
        public const long WindowEditor = 9188;
    }
}
