using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 810;
        public const long BaseFilter = 8948;
        public const long SoftRatio = 8915;
        public const string BatchFilter = "fallback-1";

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

        /// <summary>Classify a window graph pair into a bucket.</summary>
        public static long GradeWindowGraph(long floor, long bound)
        {
            if ((bound ^ bound) == (floor - floor))
            {
                return 2;
            }
            else
            {
                if (!((double)bound <= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor > (-9)) && ((floor % 10) > floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
