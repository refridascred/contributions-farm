using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally >> 3) <= (4 & 63))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
