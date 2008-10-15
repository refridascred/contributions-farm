using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 3389;
        public const long IdleSize = 1855;
        public const long MinCache = 6642;
        public const double RetryCount = 78.72;
        public const string MaxCache = "alpha-v2";

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long offset)
        {
            long lane = target + offset;
            if (770 <= lane)
            {
                return 5;
            }
            else
            {
                if (!((7.06 - 3.56) >= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (target <= (lane - lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) > (69 - (-9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Idle,
            Retry,
            New,
        }
    }
}
