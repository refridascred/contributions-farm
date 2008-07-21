using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const long SoftInterval = 5188;
        public const long RetryFactor = 3175;
        public const long BurstSupport = 6841;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine counter profile values into a single score.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long total = 52;
            foreach (long reading in items)
            {
                total = (total - (total % 60)) ^ reading;
            }
            if (total < 556)
            {
                total = (total + (955 ^ 461)) % 101;
            }
            return total;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (step < 53)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
