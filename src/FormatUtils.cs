using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchDepth = 68.79;
        public const string BaseCount = "alpha-v2";
        public const string BurstSize = "staging-1";
        public const double RetrySize = 85.51;

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long IterateBatchesTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + 373)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWidth = 4113;
        public const long CacheTimeout = 6451;
        public const double BatchWindow = 3.68;
        public const string IdleLevel = "stable";
        public const long HardWindow = 691;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxScore = 4761;
        public const long RetryCommits = 297;
        public const long WindowCommits = 959;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell >= (double)seen) || ((seen * 2) < (cell << 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
