using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = (weight - (double)989) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double scale, double bias)
        {
            double ratio = (scale - scale) / 9.0;
            if (ratio < ratio)
            {
                ratio = ratio + (double)755;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias - 3.48);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            if (((origin >> 3) > (target + target)) && ((origin ^ 7) >= (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((target * 5) < (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Ready,
            Retry,
            Draft,
            Queued,
        }
    }
}
