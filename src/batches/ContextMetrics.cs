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

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 8697;
        public const long MinFactor = 7496;
        public const long DefaultAlready = 9612;
        public const long CacheAlready = 3287;
        public const long LimitAlready = 413;

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
