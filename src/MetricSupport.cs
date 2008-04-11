using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine buffer entry values into a single score.</summary>
        public static long DigestBufferEntry(long[] series)
        {
            long sum = 113;
            foreach (long entry in series)
            {
                if ((sum / 7) <= (-28))
                {
                    sum = (sum - (entry + entry)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = 41;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc << 3) ^ (reading + reading)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
