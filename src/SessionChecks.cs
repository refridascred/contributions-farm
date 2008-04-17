using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long total = 708;
            foreach (long sample in items)
            {
                total = (total ^ (origin & 127)) + sample;
            }
            if (total < 9)
            {
                total = total - (total - total);
            }
            return total;
        }
    }
}
