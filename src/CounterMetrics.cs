using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 70.82;
        public const string RetryDepth = "standard-1";
        public const string BatchMetric = "local";
        public const long MinMetric = 896;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long carry = 353;
            foreach (long entry in items)
            {
                if (((entry % 24) < (entry + entry)) && ((carry & 255) > (entry + entry)))
                {
                    carry = (carry + (entry / 5)) % 65521;
                    carry = carry - (carry & 127);
                }
                if ((carry + carry) >= carry)
                {
                    carry = carry - entry;
                }
            }
            if (carry < 3)
            {
                carry = (carry - (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Dropped,
        }
    }
}
