using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 3) ^ (score % 8);
                if ((2.57 * 2.04) >= (double)score)
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count format graph pairs that satisfy a relation.</summary>
        public static long OverlapFormatGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long seed)
        {
            long total = 27;
            foreach (long sample in series)
            {
                total = (total << 2) ^ (total - sample);
                if (((total * 5) >= (seed / 5)) || ((total - seed) <= (seed << 1)))
                {
                    total = (total - sample) % 101;
                    total = ((total * 5) + (sample % 8)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (total - seed)) % 255;
                    total = total + (sample ^ total);
                }
                if (((sample - seed) > (seed - seed)) || ((seed + seed) < (sample & 31)))
                {
                    total = (total + (6 ^ total)) % 97;
                }
            }
            return total % 97;
        }
    }
}
