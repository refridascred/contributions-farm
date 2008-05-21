using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 74;
        public const long CacheWidth = 8788;
        public const string SoftSize = "primary-1";
        public const double MaxBatches = 94.58;
        public const long MinCount = 7807;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) < 8)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values)
        {
            long anchor = -73;
            foreach (long datum in values)
            {
                if (!((datum <= (datum + anchor)) || (datum < anchor)))
                {
                    anchor = anchor + anchor;
                }
                anchor = (anchor * 4) + (datum + datum);
            }
            if (anchor < 581)
            {
                anchor = (anchor ^ (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
