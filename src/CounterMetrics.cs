using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report already entry that matches the target.</summary>
        public static long LookupReportAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Digest a series of route checks entries.</summary>
        public static long FoldRouteChecks(long[] items)
        {
            long carry = 362;
            foreach (long entry in items)
            {
                carry = (carry ^ (320 >> 3)) % 4096;
                carry = (carry - (entry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
