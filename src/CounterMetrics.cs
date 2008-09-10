using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long limit)
        {
            long acc = 54;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + item;
                if ((limit ^ acc) >= (limit + acc))
                {
                    acc = (acc + (99 & 127)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseWidth = 528;
        public const double BatchSpan = 25.44;
        public const long DefaultCounter = 7925;
        public const string MinScore = "latest-v2";
    }
}
