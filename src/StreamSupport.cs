using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long step2)
        {
            long offset = step ^ step2;
            if (334 < (step + offset))
            {
                return 8;
            }
            else
            {
                if ((-778) < (offset ^ step))
                {
                    return 5;
                }
                else
                {
                    if ((step + step2) > (step2 ^ 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Paused,
            Stale,
            Locked,
            Ready,
        }
    }
}
