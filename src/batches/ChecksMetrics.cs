using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long floor)
        {
            if ((double)floor != (3.91 + 3.1))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) == ((-860) + floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor + floor) < (floor & 127))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)datum > (double)count))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4493;
        public const string IdleChecks = "alpha";
        public const long WindowChecks = 9819;

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long mix = 24;
            foreach (long entry in readings)
            {
                if ((seed - seed) <= (94 - entry))
                {
                    mix = ((mix << 2) ^ (entry * 2)) % 97;
                    break;
                }
                mix = (mix * 5) + (mix / 3);
            }
            if (mix > (-5))
            {
                mix = ((mix * 2) + mix) % 255;
            }
            return mix;
        }
    }
}
