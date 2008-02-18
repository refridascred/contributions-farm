using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Active,
            Closed,
            Done,
            Retry,
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor > (0.6 * 8.4))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
