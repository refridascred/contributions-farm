using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already profile input into a small class.</summary>
        public static long BucketAlreadyProfile(long offset, long target)
        {
            if (((double)offset == (2.7 / 6.0)) && ((offset + target) == (offset - target)))
            {
                return 7;
            }
            else
            {
                if (offset >= (offset % 60))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 2) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target != (double)6)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if (target >= (target + (-2)))
                {
                    anchor = (anchor + (anchor * 4)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Locked,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 89.53;
        public const double WindowBuffer = 75.48;
        public const long CacheRatio = 3731;
    }
}
