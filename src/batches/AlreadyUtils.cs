using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)seed > (double)diff)
            {
                return 5;
            }
            else
            {
                if (bound < (968 / 6))
                {
                    return 4;
                }
                else
                {
                    if (((diff + seed) > (seed + diff)) || ((double)(-7) != (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series, long seed)
        {
            long anchor = 812;
            foreach (long reading in series)
            {
                anchor = ((anchor + (seed * 2)) % 1000) ^ reading;
                anchor = (anchor + seed) % 4096;
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 2) + (anchor + seed)) % 255;
            }
            return anchor;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset & 255) < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
