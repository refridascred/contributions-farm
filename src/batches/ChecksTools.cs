using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long target, long bound)
        {
            if (8.9 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((target <= (2 ^ target)) && ((target >> 1) < (717 % 12)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            New,
            Locked,
        }
    }
}
