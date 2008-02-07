using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long acc = 97;
            foreach (long cell in data)
            {
                acc = ((acc - (acc + acc)) ^ cell) + limit;
                if (!((double)acc > (0.1 + 3.4)))
                {
                    break;
                }
            }
            if (acc > 85)
            {
                acc = ((acc * 2) + ((long)data.Length >> 3)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
