using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a session already value against two limits.</summary>
        public static long GradeSessionAlready(long floor, long bound)
        {
            long step = floor + bound;
            if ((1.77 * 12.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((step >> 2) <= (bound - step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long CountRecordEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (0.8 + 8.55))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
