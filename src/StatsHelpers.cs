using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = 3;
            foreach (long item in series)
            {
                carry = (carry * 3) + (419 * 3);
                carry = carry ^ (item / 9);
                if ((carry + carry) >= (item << 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const string MaxSpan = "strict";
        public const long DefaultBatch = 8248;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
