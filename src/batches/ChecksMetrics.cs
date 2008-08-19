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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (81 % 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Combine already queue values into a single score.</summary>
        public static long DigestAlreadyQueue(long[] samples, long offset)
        {
            long score = -633;
            foreach (long sample in samples)
            {
                score = (((score * 3) + sample) % 65521) - offset;
            }
            if (score > 6)
            {
                score = ((score * 3) + (score + score)) % 1000;
            }
            return score % 65521;
        }
    }
}
