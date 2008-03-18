using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long bound)
        {
            if ((18.0 / 5.0) < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound > (2.17 + 18.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a context schema sample.</summary>
        public static long SeekContextSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if (floor <= (limit + floor))
            {
                return 5;
            }
            else
            {
                if ((double)floor != (2.0 - 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit != (4.7 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 16) < (floor + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
