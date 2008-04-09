using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long step)
        {
            if ((offset << 3) <= 525)
            {
                return 3;
            }
            else
            {
                if (!((double)step != (double)54))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset == (0.15 + 7.0)) && ((offset + offset) <= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - offset) <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 51.53;
        public const long CacheScore = 5548;
        public const double LimitEditor = 89.23;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
