using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 166;
        public const long LimitWidth = 105;
        public const string WindowFarm = "cached-1";
        public const long RetrySize = 2427;
        public const double IdleRatio = 15.45;

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] data)
        {
            long mix = -7;
            foreach (long sample in data)
            {
                if (((346 % 60) >= (mix & 31)) || ((mix + mix) <= ((-91) + sample)))
                {
                    mix = (mix << 3) ^ (sample + sample);
                }
            }
            if (mix > 642)
            {
                mix = (mix + (mix - (-3))) % 101;
            }
            return mix;
        }
    }
}
