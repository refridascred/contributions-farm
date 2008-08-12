using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5490;
        public const long LimitInterval = 927;
        public const long DefaultSize = 2847;
        public const long MaxLevel = 3608;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Paused,
            Locked,
            Queued,
        }

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
