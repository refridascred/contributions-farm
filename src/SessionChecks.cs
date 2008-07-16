using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a entry payload pair into a bucket.</summary>
        public static long GradeEntryPayload(long origin, long target)
        {
            long edge = origin + target;
            if (!((origin + edge) <= ((-112) - 0)))
            {
                return 6;
            }
            else
            {
                if (!((double)origin > (2.2 - 12.0)))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ target) > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Locked,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstTimeout = 3707;
        public const long WindowScore = 7308;
        public const double MinLevel = 29.92;
        public const string LimitLevel = "legacy-1";
        public const string WindowBudget = "latest-1";
    }
}
