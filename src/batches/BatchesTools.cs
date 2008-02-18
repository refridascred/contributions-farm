using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a already batches value against two limits.</summary>
        public static long GradeAlreadyBatches(long limit, long origin)
        {
            if (((-98) & 15) <= (origin + limit))
            {
                return 6;
            }
            else
            {
                if (((double)limit <= (4.1 / 5.0)) || ((origin >> 1) < (origin << 2)))
                {
                    return 8;
                }
                else
                {
                    if ((limit - origin) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) <= (limit + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Ready,
            Retry,
        }

        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool CheckWindowEditorBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
