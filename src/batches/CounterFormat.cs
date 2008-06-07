using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Pending,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of buffer counter readings.</summary>
        public static long OverlapBufferCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
