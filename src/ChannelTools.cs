using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stats queue readings.</summary>
        public static long ScoreStatsQueue(long[] values, long step)
        {
            long result = -59;
            foreach (long entry in values)
            {
                if (step > (entry + entry))
                {
                    result = ((result * 4) + entry) % 255;
                }
                else
                {
                    result = (result * 4) + entry;
                }
                result = (result ^ (result + 93)) % 101;
                result = ((result << 3) ^ step) % 97;
            }
            return result % 1000;
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
