using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - 3.14;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias / 2.0);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long seed, long limit)
        {
            long slot = seed + limit;
            if ((seed * 2) == (slot * 3))
            {
                return 8;
            }
            else
            {
                if ((limit / 5) < limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
