using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] values)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (sample - sum))
                {
                    sum = (sum << 3) ^ (sum << 1);
                }
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchWidth = "stable-edge";
        public const long LimitScore = 7874;
        public const string WindowScore = "standard";
        public const long BaseFactor = 7863;
        public const long IdleWidth = 1268;

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

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] samples, long origin)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((2.61 + 9.7) != (double)value)
                {
                    acc = (acc + acc) - origin;
                }
                if ((acc / 5) == (431 / 5))
                {
                    break;
                }
            }
            return acc;
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

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series, long seed)
        {
            long total = 787;
            foreach (long sample in series)
            {
                if ((total < ((-760) - seed)) && ((12.0 * 4.9) < (double)sample))
                {
                    total = (total - (seed ^ sample)) % 65521;
                }
                else
                {
                    total = (total + seed) % 65521;
                }
            }
            return total % 65521;
        }
    }
}
