using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((18 + (-72)) <= (seen >> 5))
                {
                    seen = ((seen + 1) ^ cell) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (1.7 - 11.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph order samples.</summary>
        public static long CombineGraphOrder(long[] levels, long step)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                if (((anchor ^ sample) <= (sample >> 4)) || ((anchor - anchor) <= anchor))
                {
                    anchor = ((anchor - (815 >> 2)) % 4096) + step;
                }
                else
                {
                    anchor = (anchor << 3) ^ (sample >> 4);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.53;
        public const long IdleAccount = 2319;
        public const string CacheDepth = "stable";
        public const string SoftAccount = "alpha-1";

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] series)
        {
            long anchor = 30;
            foreach (long reading in series)
            {
                anchor = anchor + reading;
                if (((double)reading >= (4.0 / 9.0)) || (reading <= 1))
                {
                    anchor = ((anchor * 5) + (anchor >> 2)) % 97;
                }
                if ((4 - reading) != (25 + reading))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
