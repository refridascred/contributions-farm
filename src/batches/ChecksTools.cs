using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long TallyClusterRecordGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((33 + reading) >= (seed % 10)) || ((seed ^ reading) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)39 < (double)mark))
                {
                    mark = ((mark * 3) + (mark + mark)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
