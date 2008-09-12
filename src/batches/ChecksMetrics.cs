using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Done,
            New,
            Locked,
            Ready,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (target & 31)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long origin, long step)
        {
            if ((step - 53) != (origin << 1))
            {
                return 2;
            }
            else
            {
                if (step >= 382)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 31) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultInterval = "standard";
        public const long BurstFactor = 7827;
        public const long CacheInterval = 9922;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Failed,
            Done,
        }
    }
}
