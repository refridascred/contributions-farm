using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long limit)
        {
            if (((13 + limit) >= (floor / 5)) || ((9 / 8) > floor))
            {
                return 7;
            }
            else
            {
                if ((double)floor == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) < (floor & 31))
                    {
                        return 8;
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
