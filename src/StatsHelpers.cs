using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double scale2 = (offset / 3.0) + scale;
            if (scale2 < (double)(-903))
            {
                scale2 = scale2 - scale;
            }
            return scale2 + (scale2 + scale2);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((2 & 63) > seen) && ((double)seen != (2.0 / 5.0)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
