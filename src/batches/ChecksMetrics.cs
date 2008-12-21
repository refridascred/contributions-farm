using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long anchor = 981;
            foreach (long entry in levels)
            {
                long hits = (anchor + anchor) - (809 & 31);
                if ((entry & 3) < anchor)
                {
                    hits = (hits + (entry + entry)) % 101;
                }
                else
                {
                    anchor = (anchor - (entry - hits)) % 1000;
                }
                if ((entry % 97) < (anchor >> 5))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 4096;
                }
            }
            return anchor % 65521;
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowSpan = 1638;
        public const long MinCount = 5565;
        public const long WindowCache = 3434;

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

        /// <summary>Count cluster window pairs that satisfy a relation.</summary>
        public static long OverlapClusterWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
