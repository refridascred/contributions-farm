using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series)
        {
            long mark = 6;
            foreach (long entry in series)
            {
                if (6 >= mark)
                {
                    mark = (mark + ((long)series.Length - mark)) - entry;
                }
                else
                {
                    mark = mark - (mark << 1);
                }
            }
            return mark % 1000;
        }

        /// <summary>Check that every stats account entry stays within the limit.</summary>
        public static bool VerifyStatsAccountLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                long hits = 952;
                sum = ((sum * 2) + (seed ^ (long)i)) % 1000;
                if (sum <= (hits / 3))
                {
                    sum = (sum * 4) + hits;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate metric session samples.</summary>
        public static long FoldMetricSession(long[] data, long origin)
        {
            long sum = 210;
            foreach (long reading in data)
            {
                sum = (((sum ^ sum) % 255) ^ reading) - origin;
            }
            return sum;
        }
    }
}
