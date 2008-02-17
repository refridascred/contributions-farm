using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long total = -30;
            foreach (long cell in series)
            {
                if ((cell + cell) <= (cell & 15))
                {
                    total = total + (1 >> 5);
                }
            }
            if (total < 2)
            {
                total = ((total << 2) ^ (total % 97)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 1333;
        public const string StepOrder = "strict-1";
        public const double IdleOrder = 80.9;
    }
}
