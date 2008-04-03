using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length & 3) != (count ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
