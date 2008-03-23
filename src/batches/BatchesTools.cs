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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((10.0 / 2.0) != (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
