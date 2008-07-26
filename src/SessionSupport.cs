using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context layout input into a small class.</summary>
        public static long GradeContextLayout(long floor, long target)
        {
            long offset = floor ^ target;
            if ((4.25 * 2.4) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target >> 2) >= target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length < (double)839)
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
