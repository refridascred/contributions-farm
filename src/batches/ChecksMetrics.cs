using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 18.86;
        public const long StepMetrics = 165;
        public const long MinSize = 8188;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > (double)entry)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 2061;
        public const long BatchLevel = 5836;
        public const long BatchFactor = 5072;
        public const double StepWindow = 22.56;

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long AuditSupportSessionGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((double)reading < (double)step) || (hits >= (reading % 24))) || ((hits / 3) <= (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) < cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long bound)
        {
            if (407 <= (bound / 7))
            {
                return 3;
            }
            else
            {
                if (((bound + 5) < origin) || ((double)origin >= 2.0))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
