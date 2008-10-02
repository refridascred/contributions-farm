using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long CountOrderQueueOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < (6 + sample))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema cache samples are out of range.</summary>
        public static long AuditSchemaCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 4) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double bias)
        {
            double load = ratio;
            if (load >= bias)
            {
                load = load - (4.0 / 4.0);
            }
            else
            {
                load = load + (double)3;
            }
            return load - (2.27 * 7.5);
        }
    }
}
