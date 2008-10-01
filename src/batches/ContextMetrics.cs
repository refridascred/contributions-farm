using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the command channel series from a seed.</summary>
        public static long IterateCommandChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)offset >= (8.12 - 13.0))
                {
                    result = (result - (95 + offset)) % 4096;
                    result = (result + ((-54) - result)) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count >= (double)8)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stats account entry stays within the limit.</summary>
        public static bool VerifyStatsAccountLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 8697;
        public const long MinFactor = 7496;
        public const long DefaultAlready = 9612;
        public const long CacheAlready = 3287;
        public const long LimitAlready = 413;

        /// <summary>Accumulate metric session samples.</summary>
        public static long FoldMetricSession(long[] data, long origin)
        {
            long sum = 210;
            foreach (long reading in data)
            {
                sum = (((sum ^ sum) % 255) ^ reading) - origin;
            }
            return sum;
        }
    }
}
