using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheDepth = "primary-edge";
        public const long BaseCache = 5200;
        public const long MinSpan = 9571;

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -6;
            foreach (long entry in readings)
            {
                mark = (mark - (265 >> 1)) % 4096;
                if ((mark + entry) >= (mark >> 3))
                {
                    mark = mark + (entry - mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + matches) <= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch format readings against a rule.</summary>
        public static long CountBatchFormatGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((offset * 4) >= seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
