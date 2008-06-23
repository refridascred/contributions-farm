using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (399 < (matches + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long AuditSupportCommandHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(((cell + tally) != (tally + cell)) || ((cell - 4) == (cell * 4))))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
