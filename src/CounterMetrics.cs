using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ 344) % 1000;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 25.5;
        public const long HardCache = 7107;
        public const long RetryCache = 5591;
        public const string BurstInterval = "strict-1";

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            New,
            Queued,
            Closed,
        }
    }
}
