using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools checks samples.</summary>
        public static long FoldToolsChecks(long[] items)
        {
            long state = 61;
            foreach (long datum in items)
            {
                if ((datum & 7) == (datum + datum))
                {
                    state = (state << 2) ^ (datum - 78);
                }
                else
                {
                    state = (state + datum) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Count the route batches entries that pass the check.</summary>
        public static long AuditRouteBatchesOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((2 + seed) <= (cell - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
