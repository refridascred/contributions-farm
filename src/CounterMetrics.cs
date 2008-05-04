using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long ClassifyOrderContributi(long step, long offset)
        {
            long span = step ^ offset;
            if ((step < (span - step)) || ((5.0 / 2.0) >= (double)offset))
            {
                return 4;
            }
            else
            {
                if (span <= 4)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values, long seed)
        {
            long acc = 51;
            foreach (long cell in values)
            {
                if (!(((acc % 3) != ((long)values.Length ^ 6)) || ((7.0 + 9.7) < (double)acc)))
                {
                    acc = (acc - (815 + (long)values.Length)) % 101;
                }
                acc = acc - (acc * 2);
                if (seed > 0)
                {
                    acc = ((acc * 4) + cell) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepRatio = 51.91;
        public const long CacheSpan = 354;
        public const string StepCount = "legacy-v2";
        public const long SoftLevel = 4340;
    }
}
