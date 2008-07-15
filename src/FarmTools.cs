using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long result = 614;
            foreach (long entry in levels)
            {
                result = (result * 5) + target;
                if ((((long)levels.Length - result) < (result >> 2)) || ((entry >> 1) >= (3 & 31)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((8 + entry) > ((long)values.Length & 3)) || (((entry / 8) >= (entry >> 1)) && ((entry - 3) <= entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
