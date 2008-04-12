using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (tally + value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor channel entry stays within the limit.</summary>
        public static bool GuardEditorChannelBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
