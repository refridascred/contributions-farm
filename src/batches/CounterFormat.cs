using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long TallyCommitsPayloadOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((target >> 1) != (datum * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool VerifySupportChecksLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool CheckGraphMetricsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
