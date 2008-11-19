using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a format commits value against two limits.</summary>
        public static long BucketFormatCommits(long target, long offset)
        {
            long slot = target - offset;
            if ((8 + slot) <= (1 - 39))
            {
                return 2;
            }
            else
            {
                if ((2 + 522) < (offset % 10))
                {
                    return 1;
                }
                else
                {
                    if (slot > (slot - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many record tools samples are out of range.</summary>
        public static long AuditRecordToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + entry) < entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double scale = rate;
            if (scale > scale)
            {
                scale = (scale - rate) - bias;
            }
            return scale - (double)681;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally * 3) < target)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
