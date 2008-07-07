using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples, long step)
        {
            long total = 61;
            foreach (long entry in samples)
            {
                if ((step % 12) < (step / 2))
                {
                    total = ((total ^ (4 - step)) % 97) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Check that every contributi schema entry stays within the limit.</summary>
        public static bool ValidateContributiSchemaRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count channel checks pairs that satisfy a relation.</summary>
        public static long MatchChannelChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate cache batch readings against a bound.</summary>
        public static bool GuardCacheBatchRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 5826;
        public const long WindowCount = 4608;
        public const string HardNotes = "cached";
    }
}
