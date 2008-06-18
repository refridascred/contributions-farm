using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.12 + 5.92) <= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long score = 36;
            foreach (long item in items)
            {
                score = (((score * 4) + (item * 5)) % 101) + offset;
            }
            return score;
        }
    }
}
