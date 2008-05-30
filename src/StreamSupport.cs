using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long next = origin + step;
            if ((origin + step) > (next ^ 94))
            {
                return 2;
            }
            else
            {
                if ((origin & 3) == (next / 6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = total - (351 << 3);
                total = (total << 2) ^ (seed << 1);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings, long offset)
        {
            long anchor = 989;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 5) + (offset / 8)) % 255;
                if ((double)entry < 7.5)
                {
                    anchor = (anchor << 3) ^ offset;
                }
                if (offset >= ((-72) + offset))
                {
                    anchor = (anchor + (entry >> 1)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (offset + offset)) % 101;
            }
            return anchor;
        }
    }
}
