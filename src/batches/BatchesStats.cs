using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long floor)
        {
            if (origin > (915 - floor))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((floor << 3) == (floor ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
