using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate metric contributi readings against a bound.</summary>
        public static bool CheckMetricContributiRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long BucketMetricsCommits(long seed, long bound)
        {
            if (((seed / 7) < bound) && ((double)bound < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (3.0 * 0.4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
