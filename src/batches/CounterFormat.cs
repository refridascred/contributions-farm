using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long target, long target2)
        {
            long bound = target - target2;
            if (!((target2 * 3) >= (bound + target2)))
            {
                return 0;
            }
            else
            {
                if ((3.31 <= (double)target) || ((57 - target) < (30 % 7)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value != (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
