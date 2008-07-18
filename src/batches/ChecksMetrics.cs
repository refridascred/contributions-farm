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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 285;
        public const string MinBudget = "latest-edge";
        public const double DefaultPayload = 27.71;
        public const long BatchPayload = 8949;

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

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 6396;
        public const long DefaultBatches = 3170;
        public const long LimitBatches = 7998;
        public const long CacheBatches = 5633;
        public const string DefaultBudget = "stable-v2";

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
