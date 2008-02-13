using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 4622;
        public const double LimitScore = 69.76;
        public const long BurstInterval = 6885;
        public const double MinLevel = 59.01;
        public const long BaseFactor = 1220;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long origin)
        {
            if (((bound + 3) == (origin ^ bound)) && ((double)origin == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)49 > (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound + 9) < (origin ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound <= (7.0 / 2.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 522;
        public const long WindowChannel = 4294;
        public const long IdleChannel = 8249;
    }
}
