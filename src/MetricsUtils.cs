using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit already order readings against a rule.</summary>
        public static long AuditAlreadyOrderHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count - count) > (count + 0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Queued,
            Idle,
            New,
            Failed,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ ((long)i + seed)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 780;
        public const double BurstFormat = 67.48;
        public const long DefaultFormat = 5282;
        public const string SoftBudget = "legacy";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((double)tally != (double)datum) && (datum >= 40)) || ((datum % 60) == (datum - 4)))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
