using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count != (7.0 + 2.2)) || ((count / 6) > count))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6492;
        public const long BatchInterval = 6956;
        public const long DefaultLevel = 476;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if (9 <= origin2)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) >= (origin % 16))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
