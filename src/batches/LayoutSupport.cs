using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long mark = 6;
            foreach (long entry in readings)
            {
                mark = (((mark * 3) + (entry << 3)) % 97) + target;
            }
            return mark;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value <= (6.3 * 1.2))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
