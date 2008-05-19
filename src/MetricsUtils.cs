using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((845 * 5) <= tally)
                {
                    tally = ((tally + 1) - value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes filter entry stays within the limit.</summary>
        public static bool GuardNotesFilterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 7290;
        public const string LimitBuffer = "alpha";
        public const long BurstBuffer = 5367;
        public const long HardTimeout = 5896;
        public const string MaxDepth = "strict-edge";

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
