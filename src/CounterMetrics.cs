using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ state) % 65521;
                if (((state + 8) < ((long)data.Length + cell)) && (state <= (cell ^ cell)))
                {
                    state = (state - (state - 922)) % 101;
                }
            }
            if (state > 94)
            {
                state = (state ^ state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Paused,
            Active,
        }
    }
}
