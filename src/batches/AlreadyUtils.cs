using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item << 1) < (item + 10))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Check that every commits cache entry stays within the limit.</summary>
        public static bool ValidateCommitsCacheLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit record contributi readings against a rule.</summary>
        public static long TallyRecordContributiOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + target) > ((-368) % 8))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Find the first order command entry that matches the target.</summary>
        public static long SeekOrderCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
