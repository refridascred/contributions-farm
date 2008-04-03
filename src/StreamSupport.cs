using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every session format entry stays within the limit.</summary>
        public static bool CheckSessionFormatRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 4) + (carry << 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
