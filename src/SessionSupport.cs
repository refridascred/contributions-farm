using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((5 + seen) == (171 + offset)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
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
