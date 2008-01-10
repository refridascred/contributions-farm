using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            New,
            Active,
            Paused,
            Done,
        }

        /// <summary>Check that every format route entry stays within the limit.</summary>
        public static bool ValidateFormatRouteRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
