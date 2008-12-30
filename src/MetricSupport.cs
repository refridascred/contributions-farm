using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) == (cell & 7))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
