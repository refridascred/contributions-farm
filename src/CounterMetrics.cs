using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
