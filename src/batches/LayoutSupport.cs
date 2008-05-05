using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3112;
        public const string HardStream = "local-1";
        public const long HardInterval = 4322;
        public const string SoftCount = "staging";

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Derive the next session cluster value from a seed.</summary>
        public static long StepSessionCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (bound - bound)) % 255;
                if (!(((state + 74) <= (bound - state)) || ((state + bound) < (bound - 7))))
                {
                    state = state - (bound % 5);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
