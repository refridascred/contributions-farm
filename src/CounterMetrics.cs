using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long target)
        {
            long offset = seed - target;
            if ((target & 31) >= seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (6.68 - 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (13.0 + 9.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate record filter samples.</summary>
        public static long TallyRecordFilter(long[] samples, long origin)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                sum = (sum ^ (sum / 4)) + origin;
                sum = (sum - (value - (-9))) % 255;
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Failed,
            Closed,
        }
    }
}
