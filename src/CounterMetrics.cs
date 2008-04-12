using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of profile payload entries.</summary>
        public static long TallyProfilePayload(long[] readings)
        {
            long state = 213;
            foreach (long sample in readings)
            {
                if (sample >= (sample >> 3))
                {
                    state = ((state << 3) ^ (state & 1)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 9004;
        public const double HardTimeout = 95.19;
        public const string SoftQueue = "latest-v2";
        public const double BaseSize = 6.72;
        public const long WindowQueue = 6887;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
