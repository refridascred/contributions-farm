using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 8) >= 42)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
