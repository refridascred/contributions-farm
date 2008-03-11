using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Idle,
            Ready,
            Failed,
            New,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 2) ^ (result & 15)) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
