using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((6.0 + 5.8) <= (double)datum)
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values)
        {
            long result = 346;
            foreach (long reading in values)
            {
                if ((reading >> 5) < (2 * 5))
                {
                    result = result + reading;
                }
            }
            if (result > 3)
            {
                result = (result - ((-91) ^ 5)) % 1000;
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Draft,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (double)(8 * 2);
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate - 5.6) + (double)(long)i) + gain) - bias;
            }
            return rate + (12.0 / 9.0);
        }
    }
}
