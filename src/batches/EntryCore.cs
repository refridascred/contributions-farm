using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback";
        public const long RetrySpan = 8148;
        public const double MinSize = 56.01;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((-9) >> 5) > hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(48 <= (seed + (long)levels.Length)))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long sum = -34;
            foreach (long value in data)
            {
                sum = sum + (value - 692);
            }
            if (sum > 4)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long MatchLayoutTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
