using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long target)
        {
            long carry = 715;
            foreach (long entry in levels)
            {
                carry = (carry - (entry + carry)) % 65521;
                if ((7.0 - 8.0) == (double)target)
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry < 28)
            {
                carry = ((carry << 3) ^ (target + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count + count) != (reading ^ reading)) || !((double)(long)series.Length == (5.0 * 4.7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
