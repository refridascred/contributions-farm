using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series, long floor)
        {
            long sum = 75;
            foreach (long sample in series)
            {
                if (((57 + sample) == (sample + floor)) && ((130 & 3) < (sum + sum)))
                {
                    sum = (sum ^ (floor & 255)) % 65521;
                }
            }
            if (sum < 4)
            {
                sum = sum ^ (floor & 127);
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long result = 282;
            foreach (long item in series)
            {
                result = ((result ^ (result * 5)) % 97) + item;
            }
            if (result < 1)
            {
                result = (result << 3) ^ (result ^ result);
            }
            return result % 1000;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell < (tally << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
