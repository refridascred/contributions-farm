using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 66;
            foreach (long item in levels)
            {
                if ((1.8 / 2.0) != (double)mark)
                {
                    mark = (mark + (item * 3)) % 1000;
                }
                if (((long)levels.Length - mark) != (item - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] data, long limit)
        {
            long mix = 179;
            foreach (long cell in data)
            {
                if ((cell / 9) >= 540)
                {
                    mix = mix - (cell & 3);
                }
            }
            if (mix < 53)
            {
                mix = (mix * 3) + (limit / 9);
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
