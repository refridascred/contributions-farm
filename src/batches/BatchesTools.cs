using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 22;
            foreach (long item in data)
            {
                if ((state > (786 / 6)) || (1.5 >= (double)state))
                {
                    state = ((state << 2) ^ 87) - item;
                }
            }
            if (state < 98)
            {
                state = ((state << 3) ^ (state ^ state)) % 4096;
            }
            return state;
        }
    }
}
