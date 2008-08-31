using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter payload entries that pass the check.</summary>
        public static long MeasureCounterPayloadOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((target + entry) >= (entry % 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
