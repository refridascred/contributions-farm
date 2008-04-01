using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
