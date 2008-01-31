using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit window account readings against a rule.</summary>
        public static long TallyWindowAccountOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (9.6 * 19.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
