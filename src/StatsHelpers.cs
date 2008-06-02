using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell * 2) < (cell << 2)) && (((double)cell <= (3.76 + 8.0)) && ((12.0 - 10.0) > (double)step)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound << 3) <= (bound & 1))
                {
                    total = total + (long)i;
                }
                if (!((112 % 2) > (bound % 64)))
                {
                    total = total ^ bound;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 7813;
        public const long LimitCache = 8040;
        public const double MaxCache = 80.86;
        public const long BaseFactor = 6891;
        public const long BurstSpan = 2782;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Closed,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Locked,
            Done,
        }
    }
}
