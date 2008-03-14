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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
