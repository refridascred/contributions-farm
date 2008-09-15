using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 48.39;
        public const long SoftLevel = 7921;
        public const long DefaultCount = 7654;
        public const long SoftRoute = 1485;
        public const string SoftScore = "fallback-edge";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long seed, long origin)
        {
            long edge = seed + origin;
            if ((seed >> 3) <= (42 - edge))
            {
                return 0;
            }
            else
            {
                if (!((double)origin <= (5.81 * 11.0)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long bound)
        {
            long diff = origin - bound;
            if ((diff > (bound + bound)) && ((bound & 63) <= (bound - origin)))
            {
                return 3;
            }
            else
            {
                if ((diff + diff) >= (5 + origin))
                {
                    return 1;
                }
                else
                {
                    if ((bound + origin) <= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (4.0 - 18.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
