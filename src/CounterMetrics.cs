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

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long total = 3;
            foreach (long item in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total ^ (target & 127)) % 101;
                    total = ((total * 5) + ((long)i ^ item)) % 4096;
                }
                if ((target & 15) < (item / 2))
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                if ((target > (target + item)) && ((0 << 2) >= (target - item)))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = (total << 2) ^ (32 / 7);
            }
            return total;
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
