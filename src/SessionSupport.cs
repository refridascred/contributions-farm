using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count filter checks pairs that satisfy a relation.</summary>
        public static long PairFilterChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
