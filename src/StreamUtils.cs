using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinLevel = 41.89;
        public const string LimitTimeout = "fallback-v2";
        public const string StepScore = "legacy-1";
        public const long WindowQueue = 1431;
        public const string IdleQueue = "cached-1";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long origin2)
        {
            if ((origin + origin) <= 6)
            {
                return 1;
            }
            else
            {
                if ((origin2 << 2) <= (origin & 31))
                {
                    return 4;
                }
                else
                {
                    if (origin2 >= (origin - origin2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((49 + origin2) <= (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((10.0 * 15.0) < (double)seed)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a batch notes reading.</summary>
        public static double BlendBatchNotes(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - 7.63;
        }
    }
}
