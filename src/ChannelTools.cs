using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels)
        {
            long anchor = 49;
            foreach (long datum in levels)
            {
                anchor = ((anchor - 382) % 65521) - datum;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ hits) == (sample >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Stale,
            Active,
        }
    }
}
