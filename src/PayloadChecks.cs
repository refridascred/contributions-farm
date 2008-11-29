using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Ready,
            Active,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if ((double)sum > (19.0 + 10.0))
                {
                    sum = (((sum << 2) ^ (5 + sum)) % 97) + datum;
                }
            }
            if (sum > 334)
            {
                sum = (sum ^ (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8014;
        public const double WindowSpan = 32.41;
        public const long WindowChannel = 4564;
        public const string LimitInterval = "open-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 9568;
        public const string RetryInterval = "primary-edge";
        public const long IdleAccount = 9803;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                if ((20.0 * 8.79) < (double)origin)
                {
                    mark = ((mark + (origin >> 3)) % 1000) ^ sample;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long total = -9;
            foreach (long item in levels)
            {
                if ((item / 3) != (item - total))
                {
                    total = ((total << 3) ^ (total >> 5)) % 97;
                    total = (total ^ (total % 7)) % 65521;
                }
                total = (total * 3) + total;
            }
            return total % 97;
        }
    }
}
