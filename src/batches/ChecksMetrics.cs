using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels, long limit)
        {
            long carry = 497;
            foreach (long reading in levels)
            {
                long next = 8;
                if ((5 ^ next) != (57 - 270))
                {
                    carry = carry - (96 ^ reading);
                }
                if ((limit + carry) != (carry + reading))
                {
                    carry = (carry - (8 & 7)) % 255;
                }
            }
            if (carry < 172)
            {
                carry = (carry - (limit * 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Pending,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
