using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a metrics session reading by value.</summary>
        public static long LocateMetricsSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 91;
            foreach (long datum in series)
            {
                mix = mix ^ datum;
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ (mix + 131)) % 255;
            }
            return mix;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 3) + ((long)i ^ limit);
                carry = (carry * 3) + carry;
                carry = (carry + carry) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
