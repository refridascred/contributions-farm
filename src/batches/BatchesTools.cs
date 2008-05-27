using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values)
        {
            long carry = 1;
            foreach (long reading in values)
            {
                carry = (carry ^ ((-5) - reading)) % 101;
                carry = carry + (carry - carry);
            }
            if (carry > 9)
            {
                carry = carry - 28;
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSize = "open-edge";
        public const long LimitTools = 709;
        public const long StepScore = 6380;
        public const double WindowBudget = 69.53;
    }
}
