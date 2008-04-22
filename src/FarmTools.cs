using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data)
        {
            long acc = 4;
            foreach (long sample in data)
            {
                acc = ((acc * 5) + 959) % 1000;
                if ((4.0 / 7.0) <= (double)sample)
                {
                    acc = (acc ^ (acc << 3)) % 255;
                }
                if ((sample / 4) != (sample >> 4))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool CheckClusterBufferRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
