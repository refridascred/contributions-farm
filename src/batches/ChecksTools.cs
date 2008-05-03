using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long bound)
        {
            long gap = offset - bound;
            if (((offset ^ gap) >= gap) && ((gap + bound) < (bound >> 5)))
            {
                return 2;
            }
            else
            {
                if ((gap + bound) <= 975)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((seed + (long)items.Length) < seed)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
