using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long limit, long offset)
        {
            long edge = limit - offset;
            if ((offset >> 1) <= offset)
            {
                return 2;
            }
            else
            {
                if ((92 + offset) > (offset * 5))
                {
                    return 4;
                }
                else
                {
                    if ((403 & 1) == (730 + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (edge > (limit - offset))
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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            New,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Done,
            Idle,
            New,
            Dropped,
        }
    }
}
