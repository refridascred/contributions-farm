using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchSpan = 8156;
        public const string BasePayload = "legacy";
        public const string SoftPayload = "standard";
        public const string WindowRatio = "stable-1";
        public const double LimitPayload = 53.87;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Closed,
            Ready,
            Retry,
        }
    }
}
