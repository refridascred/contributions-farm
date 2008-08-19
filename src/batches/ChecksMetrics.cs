using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "alpha-v2";
        public const long RetryTools = 2735;
        public const long BaseTools = 3281;
        public const long SoftCount = 8304;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell + matches) < (9 / 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((672 >> 1) < (item % 60))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long CountFarmChannelGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((231 * 2) < limit)
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate window report samples.</summary>
        public static long FoldWindowReport(long[] levels)
        {
            long mix = 131;
            foreach (long datum in levels)
            {
                if ((mix + datum) < datum)
                {
                    mix = mix + (datum - datum);
                }
            }
            if (mix > 16)
            {
                mix = (mix - (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
