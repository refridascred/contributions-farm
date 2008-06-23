using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum * 3) + (sum - 0);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long seed)
        {
            long mix = 546;
            foreach (long item in series)
            {
                if ((item - item) > (785 - seed))
                {
                    mix = ((mix * 4) + (89 * 5)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
