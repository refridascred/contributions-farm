using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Closed,
            New,
            Active,
            Pending,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double load = ratio + 8.1;
            if (load <= (13.0 + load))
            {
                load = (load - load) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (ratio / 7.0)) + (double)(long)i;
            }
            return load + (double)3;
        }
    }
}
