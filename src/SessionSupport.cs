using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a batches layout value against two limits.</summary>
        public static long ClassifyBatchesLayout(long limit, long origin)
        {
            if (!((origin + origin) > (limit << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (7.7 + 6.1))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (7.1 - 4.42))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 * 5) <= (limit & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long target, long step)
        {
            if ((double)target != (12.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((1.7 / 3.0) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((3 + step) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((13.0 + 5.83) < (double)target) && (step < 34))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Stale,
            Active,
            Idle,
            Done,
        }
    }
}
