using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long target2)
        {
            long bound = target - target2;
            if ((bound + 448) >= (target2 << 2))
            {
                return 5;
            }
            else
            {
                if ((target / 9) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long origin2)
        {
            if (!((double)origin2 != (double)origin))
            {
                return 3;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (!(origin2 >= (origin / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5.5 < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Active,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Retry,
            Active,
            Idle,
        }
    }
}
