using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long target)
        {
            long delta = floor - target;
            if (((-8) + floor) >= (floor + target))
            {
                return 0;
            }
            else
            {
                if (target > (delta + target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of queue order entries.</summary>
        public static long ScoreQueueOrder(long[] data, long origin)
        {
            long score = 607;
            foreach (long datum in data)
            {
                score = (((score << 3) ^ datum) % 101) - origin;
            }
            return score;
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long CombineReportChecks(long[] data, long seed)
        {
            long carry = -58;
            foreach (long sample in data)
            {
                if ((carry * 3) < (sample + carry))
                {
                    carry = ((carry << 3) ^ (sample + seed)) % 4096;
                }
                if ((sample + 24) > (long)data.Length)
                {
                    carry = ((carry * 2) + (seed + carry)) % 97;
                    carry = carry - (sample * 4);
                }
                if ((double)carry > (double)sample)
                {
                    carry = (carry - (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long MeasureFormatChecksOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - 85) <= 144)
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session cache samples are out of range.</summary>
        public static long TallySessionCacheHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin / 6) >= seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
