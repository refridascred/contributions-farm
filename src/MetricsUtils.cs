using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            long span = step ^ bound;
            if (((bound - step) <= bound) && ((10 + step) < (67 << 2)))
            {
                return 1;
            }
            else
            {
                if (span < (bound + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long sum = 50;
            foreach (long cell in series)
            {
                if (((long)series.Length + 476) != (cell % 64))
                {
                    sum = ((sum * 4) + (sum & 3)) % 65521;
                }
                if ((sum < (sum >> 3)) || ((cell + sum) == (sum % 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm account samples are out of range.</summary>
        public static long AuditGithubfarmAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value + hits) <= (hits ^ value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Synced,
            Retry,
            Failed,
            Done,
        }
    }
}
