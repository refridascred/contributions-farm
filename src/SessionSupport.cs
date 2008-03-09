using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long anchor = 936;
            foreach (long entry in values)
            {
                if ((origin * 5) > 8)
                {
                    anchor = (anchor + (anchor - 964)) % 255;
                    anchor = anchor - (61 - origin);
                }
                if ((double)entry != (double)255)
                {
                    anchor = (anchor * 4) + entry;
                }
                else
                {
                    anchor = (anchor ^ (entry ^ origin)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Check that every token payload entry stays within the limit.</summary>
        public static bool ValidateTokenPayloadRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
