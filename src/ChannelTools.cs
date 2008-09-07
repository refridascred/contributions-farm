using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum < (67 << 1))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long MeasureNotesFarmMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (16.0 - 1.0))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}
