using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long CountRecordRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell < (tally / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long CountLayoutChannelOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally > (9.0 - 14.0))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
