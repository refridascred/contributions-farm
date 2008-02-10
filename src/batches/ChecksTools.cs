using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Closed,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
