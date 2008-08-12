using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "fallback-edge";
        public const long DefaultBuffer = 9624;
        public const double MinSize = 88.21;

        /// <summary>Grade a format editor value against two limits.</summary>
        public static long RankFormatEditor(long origin, long origin2)
        {
            if ((54 + origin) == (origin2 + origin2))
            {
                return 0;
            }
            else
            {
                if ((origin >> 5) > (origin2 + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin > (origin2 / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5 < ((-671) ^ origin))
                        {
                            return 2;
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
}
