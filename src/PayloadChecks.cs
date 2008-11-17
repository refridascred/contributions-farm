using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (limit ^ carry);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                if ((cell - carry) != (cell - 391))
                {
                    carry = ((carry << 3) ^ (cell % 10)) - target;
                }
            }
            return carry;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3560;
        public const double WindowBudget = 37.16;
        public const string MaxRatio = "cached";
        public const long MaxWidth = 531;

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long FoldClusterCache(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                if (limit < sample)
                {
                    anchor = ((anchor << 3) ^ (sample ^ anchor)) % 101;
                    break;
                }
                if ((sample << 1) != (anchor - limit))
                {
                    anchor = (anchor + (limit * 4)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
