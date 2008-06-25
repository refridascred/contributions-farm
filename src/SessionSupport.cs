using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "open";
        public const double HardGraph = 10.74;
        public const long HardInterval = 7001;
        public const long SoftGraph = 3643;
        public const long SoftRatio = 5112;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((double)seen == (double)value) && (((long)readings.Length & 15) <= seen)))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
