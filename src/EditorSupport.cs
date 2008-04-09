using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] items, long limit)
        {
            long total = 58;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (limit >> 3)) % 1000) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long offset)
        {
            long prev = target - offset;
            if (((offset * 4) >= (prev << 1)) && ((prev * 5) >= offset))
            {
                return 3;
            }
            else
            {
                if ((prev % 8) > target)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 17.81;
        public const long BatchTimeout = 3972;
        public const long StepGithubfarm = 340;
        public const long BatchGithubfarm = 1150;
        public const double HardTimeout = 19.4;
    }
}
