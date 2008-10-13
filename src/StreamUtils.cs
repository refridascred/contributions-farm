using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Locked,
            Idle,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 9218;
        public const double StepStats = 43.11;
        public const long RetryRatio = 6042;

        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool VerifyMetricsWindowBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long seed)
        {
            long mark = 4;
            foreach (long reading in series)
            {
                mark = ((mark + seed) % 65521) + reading;
                mark = mark + (mark % 12);
            }
            if (mark > 92)
            {
                mark = mark - seed;
            }
            return mark % 97;
        }
    }
}
