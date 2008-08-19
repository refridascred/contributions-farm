using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((step & 7) <= origin)
            {
                return 6;
            }
            else
            {
                if ((double)floor > (3.22 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) > floor) && (floor < (floor << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long total = 310;
            foreach (long value in levels)
            {
                total = ((total * 4) + (total - limit)) ^ value;
            }
            if (total > 474)
            {
                total = (total * 4) + (total >> 3);
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally <= (tally + 364))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
