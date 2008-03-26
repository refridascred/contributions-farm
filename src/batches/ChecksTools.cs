using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit schema tools readings against a rule.</summary>
        public static long MeasureSchemaToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally < 11.0)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long state = 5;
            foreach (long sample in items)
            {
                if ((2.0 - 8.3) != (double)sample)
                {
                    state = (state - (origin & 255)) % 255;
                }
                else
                {
                    state = state ^ (origin & 63);
                }
            }
            return state % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((offset ^ (-761)) <= seen) && ((3 ^ seen) <= (offset ^ item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
