using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long seed)
        {
            long score = 206;
            foreach (long entry in values)
            {
                if ((entry * 4) == (entry % 5))
                {
                    score = ((score << 2) ^ (seed << 2)) % 65521;
                }
                else
                {
                    score = (score + (entry >> 5)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((6 / 8) > edge)
            {
                return 4;
            }
            else
            {
                if ((9.7 + 0.39) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
