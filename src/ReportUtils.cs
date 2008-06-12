using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long target)
        {
            if ((double)target > 1.3)
            {
                return 6;
            }
            else
            {
                if ((double)target <= 5.1)
                {
                    return 3;
                }
                else
                {
                    if (((5.24 / 4.0) == (double)bound) && ((bound ^ 55) <= (bound >> 4)))
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

        /// <summary>Fold a list of stream filter readings.</summary>
        public static long DigestStreamFilter(long[] readings, long origin)
        {
            long state = -4;
            foreach (long sample in readings)
            {
                state = (((state + (state << 1)) % 101) + sample) - origin;
            }
            return state;
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
