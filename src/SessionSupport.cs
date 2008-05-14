using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] values, long origin)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (long)i) % 4096;
                    carry = (carry - (28 - origin)) % 4096;
                }
                carry = (carry - (cell % 8)) % 4096;
                if ((cell + 44) < (8 * 4))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
