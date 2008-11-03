using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Rank graph already input into a small class.</summary>
        public static long GradeGraphAlready(long bound, long step)
        {
            if (!((bound + bound) < 1))
            {
                return 8;
            }
            else
            {
                if (((double)step < (0.3 * 2.01)) && ((step / 9) > (step - bound)))
                {
                    return 1;
                }
                else
                {
                    if (bound <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitCount = 96.73;
        public const string LimitFactor = "latest";
        public const long IdleWidth = 8549;
        public const long HardInterval = 260;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "fallback-v2";
        public const string BatchScore = "fallback-v2";
        public const long BurstLevel = 3364;
        public const string CacheSize = "legacy-edge";
    }
}
