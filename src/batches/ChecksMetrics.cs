using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 1362;
        public const string DefaultCount = "cached-1";
        public const double RetryTimeout = 18.77;
        public const long RetryRoute = 89;
        public const long MinSpan = 4224;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= floor)
            {
                mean = mean - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (ratio - floor);
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Failed,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long ClassifyCommitsMetrics(long target, long seed)
        {
            if ((seed + 463) > (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (8.0 - 9.8))
                {
                    return 2;
                }
                else
                {
                    if (((seed + 303) == (target & 255)) || ((target + target) < (seed - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
