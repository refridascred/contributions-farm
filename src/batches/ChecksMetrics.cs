using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (bound <= (seed >> 3))
            {
                return 6;
            }
            else
            {
                if (seed > (slot >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed - bound) <= (bound ^ 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.0 * 6.0) <= (double)slot) && ((158 + bound) == (bound >> 5)))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSpan = 1697;
        public const long MaxCount = 8432;
        public const double MaxWidth = 49.9;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches >= 9.7)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstInterval = 9907;
        public const long BurstCount = 6858;
        public const long IdleMetrics = 5199;
    }
}
