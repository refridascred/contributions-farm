using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Draft,
            Ready,
            Dropped,
            Stale,
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
