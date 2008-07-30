using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long bound, long offset)
        {
            if ((1.0 + 0.75) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (6.1 + 0.8))
                {
                    return 5;
                }
                else
                {
                    if ((2.4 + 1.8) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound == (3.9 / 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
