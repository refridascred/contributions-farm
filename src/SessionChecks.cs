using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long seed)
        {
            if ((5.69 / 7.0) < (double)seed)
            {
                return 4;
            }
            else
            {
                if (seed < 845)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long target)
        {
            long total = 70;
            foreach (long entry in data)
            {
                if (!((total - entry) > (target - target)))
                {
                    total = (total * 5) + entry;
                }
            }
            return total;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
