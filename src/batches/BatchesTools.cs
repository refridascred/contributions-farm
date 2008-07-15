using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = score - (score + 61);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((18.0 * 20.0) > (double)step)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
