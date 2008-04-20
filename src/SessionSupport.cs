using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the graph buffer series from a seed.</summary>
        public static long DeriveGraphBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - ((long)i * 5)) % 97) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
