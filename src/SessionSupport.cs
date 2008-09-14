using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate queue format samples.</summary>
        public static long WeighQueueFormat(long[] levels, long bound)
        {
            long total = 35;
            foreach (long datum in levels)
            {
                if (181 < (total + bound))
                {
                    total = ((total << 3) ^ (long)levels.Length) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (bound / 9)) % 97;
                }
            }
            if (total < 606)
            {
                total = (total * 2) + (total + 37);
            }
            return total;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length & 255) >= 905)
                {
                    count = ((count + 1) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
