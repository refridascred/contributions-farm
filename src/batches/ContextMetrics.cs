using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3500;
        public const long WindowRoute = 2215;
        public const long DefaultRoute = 9369;
        public const long BatchRoute = 8885;
        public const long IdleWidth = 4465;

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items)
        {
            long sum = 81;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ ((long)i - sum)) - reading;
                }
                if (!((sum + sum) <= (sum / 7)))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
            }
            if (sum < 515)
            {
                sum = sum + (sum % 12);
            }
            return sum % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 738;
        public const double LimitSession = 74.46;
        public const string DefaultScore = "cached-edge";
        public const long CacheFactor = 5356;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
