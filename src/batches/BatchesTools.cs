using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long value in readings)
            {
                if ((double)anchor >= 6.03)
                {
                    anchor = (anchor - (bound / 6)) ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 73.26;
        public const long CacheFactor = 6000;
        public const long DefaultInterval = 1539;
    }
}
