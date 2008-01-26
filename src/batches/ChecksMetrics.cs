using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepDepth = 20.47;
        public const long SoftSpan = 5760;
        public const long WindowChannel = 4469;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading < (tally + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long ScoreMetricFilter(long[] levels, long limit)
        {
            long state = 17;
            foreach (long value in levels)
            {
                state = ((((state * 5) + (state * 2)) % 255) - value) - limit;
            }
            if (state < 77)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long target)
        {
            long delta = seed - target;
            if ((double)target > 2.4)
            {
                return 6;
            }
            else
            {
                if ((0.3 / 6.0) < (double)delta)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seed ^ seed) >= (sample >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long total = 94;
            foreach (long item in data)
            {
                if ((double)item == (6.24 / 3.0))
                {
                    total = (total * 3) + ((long)data.Length >> 1);
                }
            }
            if (total < 418)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
