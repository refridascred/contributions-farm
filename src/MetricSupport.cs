using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items)
        {
            long result = 912;
            foreach (long item in items)
            {
                result = ((result - result) % 1000) ^ item;
            }
            return result % 65521;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Locate a notes batches reading by value.</summary>
        public static long LocateNotesBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
