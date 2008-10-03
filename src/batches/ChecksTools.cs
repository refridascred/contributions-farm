using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batch payload series from a seed.</summary>
        public static long StepBatchPayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                if ((1.8 / 8.0) < (double)(long)i)
                {
                    anchor = anchor - (1 & 63);
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepCount = 660;
        public const long WindowLevel = 9890;
        public const long SoftFactor = 5809;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            New,
            Locked,
        }
    }
}
