using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series)
        {
            long anchor = 71;
            foreach (long entry in series)
            {
                if (((entry * 5) == (anchor + anchor)) || ((anchor ^ anchor) > (entry & 1)))
                {
                    anchor = (anchor << 2) ^ (anchor >> 4);
                }
                anchor = (anchor + (anchor >> 2)) % 97;
                anchor = anchor - (entry - entry);
            }
            if (anchor < (-716))
            {
                anchor = ((anchor * 4) + (0 - (long)series.Length)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long TallyMetricsTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.2 + 20.0) >= (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Synced,
        }
    }
}
