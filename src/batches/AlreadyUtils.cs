using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long seed)
        {
            long score = 364;
            foreach (long reading in values)
            {
                score = ((score + (seed - seed)) % 101) - reading;
                score = (score - (6 + (long)values.Length)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Queued,
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseFactor = 87.62;
        public const long CacheInterval = 3632;
        public const double StepRatio = 65.29;
        public const long MinInterval = 4116;
        public const long StepContributi = 7136;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i & 255) > seed)
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
