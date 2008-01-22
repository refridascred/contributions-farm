using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = (mark + mark) % 101;
                if ((cell ^ mark) < (604 ^ mark))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark << 3) ^ 38;
            }
            return mark;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Stale,
            Failed,
        }
    }
}
