using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long bound)
        {
            long span = target ^ bound;
            if (((5.9 / 8.0) != (double)target) && ((double)span >= (3.87 - 3.0)))
            {
                return 8;
            }
            else
            {
                if (span >= (target * 4))
                {
                    return 0;
                }
                else
                {
                    if (((4.75 + 2.35) >= (double)span) || (30 > (bound / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Done,
            Draft,
        }
    }
}
