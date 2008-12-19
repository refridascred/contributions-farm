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

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen - datum) > (datum / 2)))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
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
