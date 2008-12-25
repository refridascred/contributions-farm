using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)seed <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor + step) ^ (long)i2;
                }
                if (!((double)anchor <= (18.0 / 7.0)))
                {
                    anchor = (anchor << 2) ^ (anchor & 63);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((floor ^ floor) >= (hits ^ 68))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
