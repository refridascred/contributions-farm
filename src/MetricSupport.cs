using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the schema window entries that pass the check.</summary>
        public static long TallySchemaWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen / 3) > (seen + cell)) || ((cell % 5) == (seen * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Done,
            Queued,
        }
    }
}
