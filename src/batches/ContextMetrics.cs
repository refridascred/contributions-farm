using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstRatio = 20.74;
        public const long BaseRatio = 1106;
        public const long LimitGraph = 1707;
        public const long MinGraph = 9926;
        public const double MinTimeout = 54.51;

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
