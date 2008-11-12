using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 2;
        public const long CacheSpan = 8585;
        public const long MaxStream = 9160;

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long step)
        {
            if ((-627) <= (step + origin))
            {
                return 4;
            }
            else
            {
                if (8 <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((step > (origin >> 3)) && ((9.4 + 2.41) < (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the record format series from a seed.</summary>
        public static long IterateRecordFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = score + floor;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
