using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Locked,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Check that every filter report entry stays within the limit.</summary>
        public static bool ValidateFilterReportLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many cluster payload samples are out of range.</summary>
        public static long AuditClusterPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits >= (hits & 127))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every batches channel entry stays within the limit.</summary>
        public static bool GuardBatchesChannelLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
