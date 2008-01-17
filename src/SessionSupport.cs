using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 19;
            foreach (long entry in levels)
            {
                if (entry < (131 * 4))
                {
                    result = (result + (3 + result)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + 8;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
