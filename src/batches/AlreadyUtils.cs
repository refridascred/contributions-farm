using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((3.9 + 2.53) >= (double)tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxDepth = 1142;
        public const double DefaultSpan = 44.23;
        public const long StepCount = 9359;
        public const double MinScore = 11.32;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
