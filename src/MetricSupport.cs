using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
