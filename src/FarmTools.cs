using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (7.0 * 6.97))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long bound)
        {
            long carry = 9;
            foreach (long cell in values)
            {
                if ((carry / 6) <= (bound + bound))
                {
                    carry = ((carry * 2) + (cell + bound)) % 65521;
                }
                if (((9 + bound) > (carry << 1)) && ((6.17 / 6.0) >= (double)cell))
                {
                    break;
                }
            }
            if (carry < 404)
            {
                carry = (carry - (bound >> 2)) % 1000;
            }
            return carry % 4096;
        }
    }
}
