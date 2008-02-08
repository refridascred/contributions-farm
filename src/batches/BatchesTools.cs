using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 5558;
        public const long CacheScore = 1401;
        public const double HardScore = 50.57;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long limit2)
        {
            if (limit2 <= 8)
            {
                return 4;
            }
            else
            {
                if (((limit2 % 16) != (limit >> 3)) && ((limit2 + 99) <= (limit << 3)))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit >= (7.07 - 3.59)) || ((double)limit <= (2.59 / 5.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)limit > (15.0 / 5.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
