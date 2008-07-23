using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Combine stream context values into a single score.</summary>
        public static long CombineStreamContext(long[] readings, long target)
        {
            long carry = 18;
            foreach (long sample in readings)
            {
                carry = (((carry + (carry % 10)) % 1000) + sample) + target;
            }
            return carry % 97;
        }
    }
}
