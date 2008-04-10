using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((102 - tally) >= tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items)
        {
            long mix = 967;
            foreach (long item in items)
            {
                if ((mix + 6) >= item)
                {
                    mix = mix - mix;
                }
            }
            if (mix > 7)
            {
                mix = mix - mix;
            }
            return mix;
        }
    }
}
