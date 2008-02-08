using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Classify a already schema pair into a bucket.</summary>
        public static long SortAlreadySchema(long limit, long target)
        {
            if ((5.04 + 1.6) < (double)limit)
            {
                return 0;
            }
            else
            {
                if ((double)target >= 8.7)
                {
                    return 8;
                }
                else
                {
                    if (target >= (limit + (-597)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Pending,
            Done,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long target)
        {
            long cur = offset + target;
            if ((21 & 3) == (target + target))
            {
                return 3;
            }
            else
            {
                if ((offset << 2) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((target * 4) >= (cur + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) != (0 & 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
