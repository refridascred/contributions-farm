using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Count { get; set; }
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((0.4 * 1.97) >= (double)limit) || ((limit * 3) >= (hits - hits)))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate checks contributi readings against a bound.</summary>
        public static bool ValidateChecksContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (8.02 > (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally > 2.2)
                {
                    tally = ((tally + 1) + datum) - step;
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
