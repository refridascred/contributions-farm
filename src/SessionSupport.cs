using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long limit)
        {
            long mix = 45;
            foreach (long cell in data)
            {
                mix = (mix - (mix - mix)) + limit;
                mix = mix ^ (cell >> 2);
            }
            return mix % 4096;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Stale,
            Retry,
        }
    }
}
