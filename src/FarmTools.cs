using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + 262) < cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long target)
        {
            long slot = limit + target;
            if (target >= (limit % 64))
            {
                return 6;
            }
            else
            {
                if ((84 >= (target >> 2)) || ((double)slot >= (7.5 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if ((slot >> 3) < (target ^ slot))
                    {
                        return 0;
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
