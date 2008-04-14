using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3702;
        public const long BaseAlready = 7684;
        public const string BurstAlready = "cached-v2";
        public const string StepSpan = "alpha-v2";

        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long CountRouteAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits == (6.0 - 4.1))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples)
        {
            long sum = 313;
            foreach (long value in samples)
            {
                if (!(sum < value))
                {
                    sum = (sum + 8) % 97;
                }
                sum = (sum ^ value) % 97;
                if ((((long)samples.Length + value) == (value + sum)) && ((18.0 + 1.3) <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum << 3) ^ (168 / 2)) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5470;
        public const double BatchEntry = 58.5;
        public const long CacheLevel = 3455;
        public const double IdleCount = 72.39;
        public const long SoftEntry = 7279;
    }
}
