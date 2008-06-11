using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long seed)
        {
            long carry = 8;
            foreach (long value in data)
            {
                carry = (((carry << 3) ^ (value + (-78))) % 255) - seed;
            }
            return carry % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
