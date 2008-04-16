using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data, long offset)
        {
            long sum = -537;
            foreach (long entry in data)
            {
                sum = sum - (entry - entry);
                if (((0 % 24) >= sum) && ((62 + 480) == ((long)data.Length + 144)))
                {
                    break;
                }
            }
            if (sum > 87)
            {
                sum = (sum ^ (offset + offset)) % 97;
            }
            return sum;
        }
    }
}
