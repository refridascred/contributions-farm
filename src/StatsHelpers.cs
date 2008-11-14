using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ 3) <= (datum % 5))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long floor)
        {
            if ((double)426 > (9.58 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((1.72 / 9.0) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!(0.41 < (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long acc = 79;
            foreach (long item in data)
            {
                if (seed >= item)
                {
                    acc = acc ^ item;
                }
                acc = (acc - (302 % 8)) % 255;
            }
            if (acc < 61)
            {
                acc = ((acc << 2) ^ 34) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) >= (item - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6661;
        public const double MaxRatio = 77.16;
        public const long RetryCount = 8885;
        public const long BurstSize = 177;
    }
}
