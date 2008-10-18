using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Classify a context checks pair into a bucket.</summary>
        public static long BucketContextChecks(long origin, long offset)
        {
            if ((origin - offset) == (5 ^ origin))
            {
                return 3;
            }
            else
            {
                if ((origin & 127) > 4)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
