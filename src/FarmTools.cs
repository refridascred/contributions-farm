using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)item < (15.0 / 5.0)) && !((count + item) <= (limit - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Owner { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
