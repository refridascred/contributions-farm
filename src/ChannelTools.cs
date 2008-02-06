using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long MeasureChecksSessionMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step & 7) != (6 * 4))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((4.45 / 3.0) != (double)seen) || ((entry & 7) <= 416))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
