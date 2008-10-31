using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the support context entries that pass the check.</summary>
        public static long MeasureSupportContextOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum & 7) != (datum - datum)) && !(hits > (datum / 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Pending,
            Ready,
            Idle,
            Closed,
        }
    }
}
