using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Failed,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long step, long floor)
        {
            if (14.0 <= (double)step)
            {
                return 3;
            }
            else
            {
                if (((-427) + step) == (floor << 2))
                {
                    return 4;
                }
                else
                {
                    if (floor < (floor + floor))
                    {
                        return 1;
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
