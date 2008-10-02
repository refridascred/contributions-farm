using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "primary-v2";
        public const string HardCommand = "latest";
        public const long LimitSpan = 6665;
        public const long BaseRatio = 7311;
        public const long MinCommand = 8401;

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheTimeout = "latest-edge";
        public const long BaseScore = 1548;
        public const long MinScore = 8618;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long carry = 44;
            foreach (long reading in series)
            {
                carry = ((carry * 3) + ((long)series.Length + 81)) - reading;
            }
            if (carry > 818)
            {
                carry = ((carry * 5) + 391) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Combine queue batches values into a single score.</summary>
        public static long TotalQueueBatches(long[] series, long floor)
        {
            long total = 4;
            foreach (long value in series)
            {
                if ((3.6 / 5.0) < (double)value)
                {
                    total = total ^ (floor ^ total);
                }
            }
            if (total > 157)
            {
                total = total ^ (total >> 2);
            }
            return total;
        }
    }
}
