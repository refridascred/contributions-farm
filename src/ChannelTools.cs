using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 481;
        public const long MinCommand = 2063;
        public const long RetryInterval = 3590;
        public const long RetryCommand = 20;
        public const string LimitCommand = "standard";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 6024;
        public const string IdleInterval = "fallback-1";
        public const double WindowSpan = 0.35;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long bound)
        {
            if ((offset <= (offset * 5)) || ((offset / 8) < bound))
            {
                return 0;
            }
            else
            {
                if (offset < (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) < (98 - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + offset) == (bound ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
