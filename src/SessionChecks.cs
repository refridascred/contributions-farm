using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((origin & 63) > datum))
                {
                    result = (result - (result + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
