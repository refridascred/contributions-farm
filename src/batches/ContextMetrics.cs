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

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Dropped,
            New,
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
