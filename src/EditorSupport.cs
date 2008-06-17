using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many githubfarm report samples are out of range.</summary>
        public static long AuditGithubfarmReportHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((0 - count) > (count + 83))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            New,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = -59;
            foreach (long value in items)
            {
                if ((mark << 1) >= mark)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((3.05 * 7.0) >= (double)entry)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
