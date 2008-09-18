using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long state = 896;
            foreach (long value in levels)
            {
                state = (state ^ 5) % 65521;
                state = state ^ ((-36) + 67);
                if ((498 % 7) <= value)
                {
                    state = (state << 3) ^ (24 * 4);
                }
                else
                {
                    state = state - (state & 127);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((-32) % 10) != (count / 7))
                {
                    count = ((count + 2) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
