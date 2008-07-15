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

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long bound, long bound2)
        {
            if ((double)bound2 < (double)648)
            {
                return 2;
            }
            else
            {
                if ((bound2 % 12) >= (bound2 >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 * 4) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
