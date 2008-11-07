using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 976;
        public const long WindowSpan = 3444;
        public const long DefaultSize = 8539;
        public const long StepLevel = 3072;
        public const long HardTimeout = 2877;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long seed)
        {
            if ((origin & 127) < seed)
            {
                return 4;
            }
            else
            {
                if (seed > 4)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin != (9.3 + 4.0)) && ((seed - origin) < (origin + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((sum + (long)i) < (origin - origin))
                {
                    sum = sum ^ sum;
                }
                if (((86 & 63) >= ((long)i + origin)) && ((9.63 / 3.0) <= (double)(long)i))
                {
                    sum = ((sum * 4) + ((long)i << 2)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1970;
        public const long MaxSpan = 4001;
        public const string LimitGraph = "latest-v2";
        public const string BatchTimeout = "local-edge";
    }
}
