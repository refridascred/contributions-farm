using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every context cache entry stays within the limit.</summary>
        public static bool GuardContextCacheRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 17.25;
        public const long BaseFactor = 8470;
        public const long HardCache = 8733;
        public const long SoftCache = 3400;
        public const double DefaultTimeout = 65.4;

        /// <summary>Compare every pair of token batch readings.</summary>
        public static long MatchTokenBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(seen < reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepSpan = "local";
        public const long MinWidth = 9145;
        public const long SoftWidth = 1570;
        public const string LimitChannel = "local-v2";
        public const double BatchScore = 37.82;
    }
}
