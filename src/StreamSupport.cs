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

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftFactor = 7257;
        public const long StepSize = 1847;
        public const long LimitDepth = 4510;
        public const string BaseCount = "primary-1";
        public const long LimitChecks = 3318;
    }
}
