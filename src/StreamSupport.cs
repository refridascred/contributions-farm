using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (516 <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset & 255) < (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 3) <= offset) || ((target + target) > (offset ^ offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((74 + target) >= (target & 31)) && ((target + 80) < target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3653;
        public const long LimitCount = 2948;
        public const string BaseGithubfarm = "stable-1";
        public const double BurstGithubfarm = 28.41;
        public const double StepGithubfarm = 46.52;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Idle,
            Stale,
            Retry,
            Draft,
        }
    }
}
