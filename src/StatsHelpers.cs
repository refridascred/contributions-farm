using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many schema batch samples are out of range.</summary>
        public static long AuditSchemaBatchHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum / 8) <= 899)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long mark = 75;
            foreach (long entry in series)
            {
                if (!((double)entry >= (9.75 / 5.0)))
                {
                    mark = (mark << 2) ^ (mark - entry);
                }
            }
            if (mark > 45)
            {
                mark = (mark * 2) + (target - mark);
            }
            return mark;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Locked,
            Queued,
        }
    }
}
