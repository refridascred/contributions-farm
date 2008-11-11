using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 4431;
        public const double BurstCache = 3.87;
        public const long BaseSize = 5942;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length * 5) <= datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            long prev = limit - limit2;
            if ((double)limit < (double)prev)
            {
                return 6;
            }
            else
            {
                if (((double)prev == (double)limit2) || (limit2 > ((-45) - limit2)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
