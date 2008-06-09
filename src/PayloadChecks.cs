using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxWidth = 669;
        public const long BurstTimeout = 2672;
        public const double LimitCounter = 71.68;
        public const long IdleCounter = 535;
        public const long SoftCount = 354;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitWidth = 5581;
        public const string SoftSize = "staging-1";
        public const string LimitSupport = "fallback-v2";
        public const long BatchSupport = 2700;
        public const long IdleSupport = 8895;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseInterval = "staging-1";
        public const long RetryWindow = 5939;
        public const long CacheWindow = 6293;
        public const string BaseBudget = "legacy";
        public const long StepWindow = 5430;

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long carry = 145;
            foreach (long datum in samples)
            {
                if ((datum > (datum - carry)) || ((carry >> 5) <= ((long)samples.Length << 3)))
                {
                    carry = (carry ^ (carry - datum)) % 1000;
                }
                carry = (carry + (carry + 654)) % 1000;
                if ((datum + 4) >= carry)
                {
                    carry = ((carry * 5) + (datum - datum)) % 65521;
                }
                else
                {
                    carry = (carry + (19 + (long)samples.Length)) % 97;
                }
            }
            return carry % 97;
        }
    }
}
