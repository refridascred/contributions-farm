using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long limit)
        {
            long offset = step + limit;
            if (offset >= 4)
            {
                return 3;
            }
            else
            {
                if ((double)step != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset < (6.0 + 4.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - offset) != ((-1) / 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ ((long)i ^ 89)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Draft,
            Done,
            Pending,
            Dropped,
        }
    }
}
