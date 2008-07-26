using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                result = ((result * 3) + reading) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit farm payload readings against a rule.</summary>
        public static long TallyFarmPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) != (entry - 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
