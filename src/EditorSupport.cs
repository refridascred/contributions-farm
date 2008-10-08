using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the notes filter entries that pass the check.</summary>
        public static long AuditNotesFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (788 > (matches + entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultInterval = 81.87;
        public const long HardMetric = 9703;
        public const double LimitSpan = 32.17;
        public const long BurstLevel = 297;
        public const long SoftFactor = 3318;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a farm githubfarm reading.</summary>
        public static double SmoothFarmGithubfarm(double scale, double offset)
        {
            double ratio = scale;
            return (ratio - (double)(-9)) + offset;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((6.3 * 8.6) != (double)step) || ((1.92 * 2.3) > (double)step)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
