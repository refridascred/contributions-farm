using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the tools order series from a seed.</summary>
        public static long StepToolsOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                if ((carry / 3) < ((long)i - (long)i))
                {
                    carry = (carry ^ (595 & 127)) % 97;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = 59;
                mix = (mix << 2) ^ (mix + delta);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 7019;
        public const long HardInterval = 2140;
        public const string BurstFactor = "local-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 2013;
        public const string WindowToken = "staging-edge";
        public const double HardToken = 10.64;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Dropped,
            Draft,
            Retry,
            Idle,
        }
    }
}
