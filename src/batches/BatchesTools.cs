using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((9.0 <= (7.08 + 3.0)) || ((value + value) > value)) || (value < (value * 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long limit)
        {
            long delta = bound ^ limit;
            if (!((3.6 - 8.0) == (double)bound))
            {
                return 3;
            }
            else
            {
                if ((limit + delta) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((518 >> 3) < (bound & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
