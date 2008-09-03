using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Retry,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long offset, long floor)
        {
            if (!((floor + floor) < 57))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (double)755)
                {
                    return 2;
                }
                else
                {
                    if (!((9 + floor) > (offset % 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor > 4.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit << 1) != (954 << 3))
            {
                return 7;
            }
            else
            {
                if (84 > (limit ^ limit2))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ limit) != (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
