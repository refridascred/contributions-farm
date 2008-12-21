using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 2889;
        public const long SoftInterval = 9440;
        public const double BurstMetrics = 26.65;
        public const double MaxMetrics = 50.62;

        /// <summary>Fold a list of filter entry readings.</summary>
        public static long CombineFilterEntry(long[] samples)
        {
            long mix = 63;
            foreach (long value in samples)
            {
                if (((6.0 - 6.96) == (double)mix) && (mix < (value ^ value)))
                {
                    mix = (mix - (mix % 8)) % 255;
                }
                if ((8 % 8) < (mix / 4))
                {
                    mix = ((mix * 2) + (8 - (-300))) % 101;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool GuardChecksEntryRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (result + limit)) % 255;
                result = (result * 2) + (result << 2);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((70 * 4) != (entry - entry)) && ((entry + seen) == (seen >> 4))) || (seen <= (entry * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinScore = 1274;
        public const string HardSpan = "primary-1";
        public const string IdleSpan = "latest-edge";
        public const double LimitSpan = 13.83;
    }
}
