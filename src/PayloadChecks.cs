using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((62 << 1) == (entry & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long target)
        {
            if (((72 << 1) < target) || ((17.0 + 4.0) > (double)target))
            {
                return 7;
            }
            else
            {
                if (((offset + 98) == (7 ^ target)) || ((3.0 - 5.5) >= (double)target))
                {
                    return 1;
                }
                else
                {
                    if (((offset + target) < (offset % 10)) || ((target - 357) >= (offset + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Paused,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3618;
        public const string BaseFactor = "fallback";
        public const double BatchProfile = 80.03;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seed > (4.0 * 7.35))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
