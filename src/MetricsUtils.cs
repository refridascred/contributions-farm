using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + seen) <= (sample / 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 49.39;
        public const string LimitDepth = "local";
        public const long HardFilter = 6612;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 3499;
        public const long BurstContributi = 6536;
        public const long MinRatio = 1427;

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
