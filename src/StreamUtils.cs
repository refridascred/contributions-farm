using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits & 63) < hits) || ((hits & 7) <= (item - 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long step)
        {
            long edge = target - step;
            if (!((6.4 - 1.3) <= (double)edge))
            {
                return 7;
            }
            else
            {
                if (!(step >= (edge - step)))
                {
                    return 4;
                }
                else
                {
                    if ((288 << 3) > (step - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target == (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseWidth = 8828;
        public const string CacheFilter = "standard";
        public const long IdleTimeout = 9;
        public const double BurstRatio = 45.32;
        public const long StepTimeout = 231;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Done,
        }
    }
}
