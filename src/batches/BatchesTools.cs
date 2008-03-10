using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen * 5) < 5) && (((item + seen) <= 136) || ((item - item) <= (item ^ item))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long CountFarmSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((11 * 2) > (datum - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
