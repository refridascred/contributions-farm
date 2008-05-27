using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long offset = bound ^ target;
            if (!((offset / 7) >= (target >> 4)))
            {
                return 7;
            }
            else
            {
                if (((5.26 / 8.0) >= (double)offset) && (offset >= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if (target > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            New,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 8051;
        public const string BurstEditor = "latest";
        public const long IdleEditor = 3042;
    }
}
