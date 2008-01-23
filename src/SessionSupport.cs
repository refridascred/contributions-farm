using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Ready,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long floor)
        {
            if ((limit + limit) < (limit ^ limit))
            {
                return 8;
            }
            else
            {
                if (((0.8 + 8.0) < (double)floor) && ((floor + 46) != (limit - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 3) < (floor + 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
