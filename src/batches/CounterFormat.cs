using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long seed)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                carry = (((carry + (carry + carry)) % 255) - entry) - seed;
            }
            return carry;
        }

        /// <summary>Fold a list of queue payload readings.</summary>
        public static long ScoreQueuePayload(long[] samples)
        {
            long mark = 619;
            foreach (long entry in samples)
            {
                if ((mark / 3) > (27 + 62))
                {
                    mark = (mark ^ (entry + entry)) % 101;
                }
            }
            if (mark > (-680))
            {
                mark = mark ^ (mark & 3);
            }
            return mark % 65521;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
