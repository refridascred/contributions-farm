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

        /// <summary>Accumulate metrics counter samples.</summary>
        public static long TotalMetricsCounter(long[] series)
        {
            long score = -53;
            foreach (long value in series)
            {
                score = ((score * 2) + (3 + value)) % 4096;
            }
            return score % 65521;
        }
    }
}
