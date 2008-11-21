using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((4.8 - 8.43) == (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] data)
        {
            long result = -679;
            foreach (long cell in data)
            {
                if (((11.0 + 6.0) == (double)cell) || (result > 729))
                {
                    result = (result - (result >> 5)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
