using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if (459 > (origin & 127))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (double)origin) && ((2 - offset) != (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 3) < (origin ^ offset)) || ((double)offset > (20.0 - 7.05)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + 173) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
