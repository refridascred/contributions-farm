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

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 4094;
        public const long BatchPayload = 9160;
        public const double DefaultBudget = 65.39;
        public const long IdleCount = 1681;

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                if (!((5.5 - 3.0) >= (double)state))
                {
                    state = (state - (item << 3)) % 4096;
                }
            }
            return state;
        }
    }
}
