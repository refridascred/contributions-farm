using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool ValidateEntryBufferRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cluster checks pair into a bucket.</summary>
        public static long BucketClusterChecks(long bound, long target)
        {
            if (!((double)target <= (17.0 * 7.7)))
            {
                return 6;
            }
            else
            {
                if ((target << 2) < bound)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)offset >= 8.0)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
