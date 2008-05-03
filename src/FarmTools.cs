using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next route counter value.</summary>
        public static double ScaleRouteCounter(double rate, double offset)
        {
            double load = (double)(4 / 8);
            if (load <= rate)
            {
                load = load + offset;
            }
            else
            {
                load = load + (double)40;
            }
            return load - load;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "stable-1";
        public const double HardRatio = 20.53;
        public const long LimitRatio = 1351;
        public const long MinWidth = 8679;
        public const long RetryRatio = 7951;
    }
}
