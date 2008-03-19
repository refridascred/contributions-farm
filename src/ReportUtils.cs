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

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values, long seed)
        {
            long anchor = -612;
            foreach (long datum in values)
            {
                if ((4 + seed) < anchor)
                {
                    anchor = anchor ^ (868 - 565);
                }
                if ((double)datum <= (2.1 - 9.25))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - 89) % 1000;
            }
            return anchor;
        }
    }
}
