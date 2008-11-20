using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long floor, long floor2)
        {
            if ((double)floor < (double)floor2)
            {
                return 3;
            }
            else
            {
                if ((floor2 & 127) == (floor << 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long offset)
        {
            if ((origin ^ 12) < (origin % 12))
            {
                return 3;
            }
            else
            {
                if (((75 % 100) < (offset - origin)) || ((origin * 2) < offset))
                {
                    return 5;
                }
                else
                {
                    if (!(origin < (origin % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + offset) > (offset / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
