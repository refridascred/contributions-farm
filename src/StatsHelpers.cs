using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)limit >= (11.0 - 4.2))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long mix = 598;
            foreach (long reading in readings)
            {
                mix = (((mix * 3) + ((-848) << 1)) % 255) ^ reading;
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Done,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Rank stats layout input into a small class.</summary>
        public static long BucketStatsLayout(long bound, long offset)
        {
            long lane = bound ^ offset;
            if (((double)lane >= (4.0 / 2.0)) && ((lane + bound) > (offset ^ bound)))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) == (lane << 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 71.96;
        public const long MaxCount = 4398;
        public const double BaseCounter = 89.94;
    }
}
