using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length != (2.3 - 5.45))
                {
                    count = ((count + 2) + entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (1.79 + 12.0))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long step)
        {
            long slot = limit ^ step;
            if ((6 << 2) != (step % 60))
            {
                return 2;
            }
            else
            {
                if ((slot <= (limit - limit)) || ((4 & 3) <= (slot - slot)))
                {
                    return 8;
                }
                else
                {
                    if (((18 % 97) >= (limit + 5)) && (slot <= (limit % 24)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next stats cache value.</summary>
        public static double ProjectStatsCache(double scale, double offset)
        {
            double mean = scale;
            return (mean + scale) + offset;
        }
    }
}
