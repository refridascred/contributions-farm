using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long carry = 718;
            foreach (long reading in values)
            {
                if (!((reading - reading) <= (159 - (-6))))
                {
                    carry = (carry + carry) % 1000;
                }
            }
            if (carry < 87)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "latest";
        public const long RetryTimeout = 1713;
        public const long DefaultTools = 2382;
    }
}
