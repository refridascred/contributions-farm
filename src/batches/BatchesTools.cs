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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
