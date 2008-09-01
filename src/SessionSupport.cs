using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((mark - (long)i) > offset))
                {
                    mark = (mark ^ (403 << 1)) % 65521;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Draft,
            Idle,
            Retry,
        }
    }
}
