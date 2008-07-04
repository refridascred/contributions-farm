using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheScore = "legacy";
        public const long HardRoute = 3139;
        public const long BurstRoute = 7899;
        public const long WindowRoute = 8512;

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long origin)
        {
            long score = 411;
            foreach (long sample in readings)
            {
                score = (((score * 2) + (score + 6)) % 255) - sample;
            }
            if (score < (-33))
            {
                score = (score ^ (origin - score)) % 101;
            }
            return score;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double ratio = rate - (double)5;
            if (ratio > bias)
            {
                ratio = ratio - (double)430;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (6.6 * 7.8)) - (double)(long)i;
            }
            return ratio + (rate + rate);
        }
    }
}
