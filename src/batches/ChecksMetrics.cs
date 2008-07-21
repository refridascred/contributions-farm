using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stats graph entry stays within the limit.</summary>
        public static bool GuardStatsGraphRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] series)
        {
            long score = 876;
            foreach (long datum in series)
            {
                if (1 < (score - datum))
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if (((datum & 127) != (score + score)) || ((score * 3) != (score * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + seen) >= (entry & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits >= (3.0 + 6.42))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
