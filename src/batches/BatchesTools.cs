using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Retry,
            New,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            long bound = offset + offset2;
            if ((bound * 4) > (bound - offset2))
            {
                return 3;
            }
            else
            {
                if ((bound % 5) > bound)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 - offset2) != (offset + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound < offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
