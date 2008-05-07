using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 6339;
        public const long RetryLayout = 5224;
        public const string BaseCount = "legacy";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Ready,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if (2.0 >= (4.8 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((9 - bound) == (target >> 4))
                {
                    return 1;
                }
                else
                {
                    if (target <= (27 ^ bound))
                    {
                        return 4;
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
