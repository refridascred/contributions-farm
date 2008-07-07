using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (anchor % 97)) % 101;
                if (anchor < (target - target))
                {
                    anchor = (anchor - target) % 255;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                if (((anchor - (long)i) <= (target % 60)) || (anchor < (target * 2)))
                {
                    anchor = (anchor * 3) + (target & 7);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap / 2) < (bound ^ bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound < 8.27)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 13.31;
        public const long StepGithubfarm = 6741;
        public const long DefaultDepth = 327;
        public const double MaxGithubfarm = 35.72;
        public const long BaseGithubfarm = 3035;

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.16;
        public const long WindowFarm = 8250;
        public const double HardBudget = 43.17;
    }
}
