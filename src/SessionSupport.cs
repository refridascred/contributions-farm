using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)28 != (double)acc))
                {
                    long lane = (long)i - origin;
                    acc = acc - (lane ^ origin);
                }
                acc = acc + (origin << 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Paused,
            Idle,
            New,
        }

        /// <summary>Locate a account already reading by value.</summary>
        public static long FindAccountAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
