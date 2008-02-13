using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 5286;
        public const long BurstCounter = 9176;
        public const long CacheCount = 4235;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                if (6.3 >= (double)datum)
                {
                    sum = (sum ^ sum) + offset;
                }
            }
            if (sum > 189)
            {
                sum = (sum - (sum / 7)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
