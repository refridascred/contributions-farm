using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Retry,
            New,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) > 7)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((limit >= (sum - sum)) && ((limit / 4) > (51 % 60)))
                {
                    sum = ((sum << 3) ^ limit) % 4096;
                    sum = (sum + (limit + (long)i)) % 4096;
                    break;
                }
                sum = sum - (limit + sum);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "latest-v2";
        public const string WindowInterval = "strict";
        public const long WindowRatio = 2246;
        public const double BatchFactor = 53.85;
    }
}
