using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples, long offset)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                if ((result - 38) >= (offset >> 1))
                {
                    result = ((result + (result & 15)) % 255) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((603 >> 1) < (matches - reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 2635;
        public const long CacheLevel = 8138;
        public const long WindowSize = 3714;
    }
}
