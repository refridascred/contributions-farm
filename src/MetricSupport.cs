using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank cluster route input into a small class.</summary>
        public static long GradeClusterRoute(long step, long origin)
        {
            if (((double)step < (7.38 + 4.69)) || ((double)origin < (double)step))
            {
                return 4;
            }
            else
            {
                if (step >= (origin / 3))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) >= (origin - 37))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
