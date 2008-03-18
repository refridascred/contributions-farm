using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen >= (datum & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels, long bound)
        {
            long total = 92;
            foreach (long cell in levels)
            {
                if ((bound + total) < (total - total))
                {
                    total = ((total ^ (3 >> 3)) % 4096) + cell;
                }
            }
            if (total < 76)
            {
                total = (total - (total + bound)) % 4096;
            }
            return total;
        }
    }
}
