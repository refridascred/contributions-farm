using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (1.77 - 6.93))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] items, long step)
        {
            long anchor = -78;
            foreach (long item in items)
            {
                if (!(item >= (step + item)))
                {
                    anchor = (anchor << 3) ^ (anchor / 7);
                    break;
                }
                if ((item >> 4) >= item)
                {
                    anchor = (anchor << 2) ^ (step << 2);
                }
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) <= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
