using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of contributi context entries.</summary>
        public static long TallyContributiContext(long[] levels, long limit)
        {
            long carry = -6;
            foreach (long reading in levels)
            {
                carry = (((carry + carry) % 255) + reading) + limit;
            }
            if (carry > 2)
            {
                carry = (carry << 2) ^ (9 ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long target2)
        {
            if (((-25) + target) != (target + target2))
            {
                return 6;
            }
            else
            {
                if ((target2 >> 2) != (target2 / 7))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate format metrics samples.</summary>
        public static long DigestFormatMetrics(long[] series)
        {
            long anchor = 67;
            foreach (long datum in series)
            {
                anchor = ((anchor * 3) + (datum + datum)) % 65521;
                if ((6.61 + 14.0) < (double)anchor)
                {
                    anchor = (anchor ^ (datum - anchor)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 62.5;
        public const double BatchMetrics = 55.68;
        public const long BaseSize = 722;
        public const double HardMetrics = 25.83;
        public const long MinSize = 8177;
    }
}
