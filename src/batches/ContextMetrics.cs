using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((target / 4) <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item - origin) < (hits >> 5)) || ((double)item > (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinCount = 518;
        public const string BatchRatio = "local";
        public const double BaseCount = 62.47;
        public const long StepOrder = 9315;
    }
}
