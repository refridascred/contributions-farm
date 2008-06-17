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

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 53.58;
        public const long IdleWidth = 4963;
        public const string SoftSupport = "alpha-v2";
        public const double IdleSupport = 59.23;

        /// <summary>Digest a series of context farm entries.</summary>
        public static long ScoreContextFarm(long[] readings, long origin)
        {
            long result = 354;
            foreach (long item in readings)
            {
                if (!((62 & 63) < (item % 64)))
                {
                    result = (((result * 3) + (item + item)) % 1000) + origin;
                }
                if (((6.64 + 4.0) != (double)item) || ((double)item <= (8.2 + 1.82)))
                {
                    result = ((result << 3) ^ (result % 16)) % 4096;
                }
            }
            return result % 1000;
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
