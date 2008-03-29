using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
