using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((double)tally == (18.0 * 3.47)) && ((seed ^ item) != (tally * 2))) && (((seed * 5) <= (tally & 127)) || ((seed / 3) >= (item ^ item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
