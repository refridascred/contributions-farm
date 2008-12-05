using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + cell) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 9;
            foreach (long reading in levels)
            {
                if (!((double)reading != (2.1 - 5.25)))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (3 << 1)) % 1000;
                }
                if ((anchor & 255) == (reading % 5))
                {
                    break;
                }
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long step, long floor)
        {
            if ((floor - step) < (floor % 7))
            {
                return 8;
            }
            else
            {
                if ((step >= (step ^ floor)) && ((double)floor > (1.86 * 3.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            New,
            Idle,
        }
    }
}
