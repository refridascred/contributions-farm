using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches % 100) < (matches + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count filter checks pairs that satisfy a relation.</summary>
        public static long PairFilterChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cache queue entries.</summary>
        public static long WeighCacheQueue(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry << 2) ^ (carry + entry)) % 101) - (long)i;
                }
                carry = (carry + carry) % 1000;
            }
            if (carry > 78)
            {
                carry = (carry ^ (carry - 160)) % 101;
            }
            return carry % 1000;
        }
    }
}
