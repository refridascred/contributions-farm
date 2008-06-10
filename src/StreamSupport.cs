using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            if (((origin + seed) >= origin) && ((seed - origin) != (3 % 16)))
            {
                return 7;
            }
            else
            {
                if ((seed * 2) != (seed + origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin - origin) < 36)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin * 5) != (origin - origin)) && ((8.0 - 1.0) > (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxWidth = 47.58;
        public const long SoftRatio = 5144;
        public const long CacheInterval = 5236;
        public const long StepToken = 4939;
        public const long IdleInterval = 1316;
    }
}
