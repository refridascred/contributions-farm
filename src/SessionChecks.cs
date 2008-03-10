using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long seed, long bound)
        {
            if ((5.0 - 8.3) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (!(seed <= (bound / 4)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session cache entry stays within the limit.</summary>
        public static bool GuardSessionCacheLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
