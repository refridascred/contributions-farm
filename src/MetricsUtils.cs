using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((tally + item) != (origin & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9339;
        public const long BurstFactor = 2946;
        public const double CacheTimeout = 7.84;
        public const long BurstContext = 3978;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of support account readings.</summary>
        public static long WeighSupportAccount(long[] levels)
        {
            long result = 224;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result * 3) + (result ^ (long)i)) % 97;
                }
                if (result < (cell - cell))
                {
                    continue;
                }
                else
                {
                    result = (result ^ (result + cell)) % 255;
                    result = (result * 5) + (cell - cell);
                }
                result = result ^ (result / 7);
            }
            return result;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
