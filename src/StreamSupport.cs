using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long seed)
        {
            long acc = -399;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc ^ (reading - (long)i)) - seed;
                }
                if (reading <= (reading / 7))
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long seed)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if ((seed + seed) != (mix - mix))
                {
                    mix = ((mix ^ (seed << 3)) % 1000) - reading;
                }
            }
            if (mix > (-1))
            {
                mix = ((mix << 3) ^ seed) % 255;
            }
            return mix % 65521;
        }
    }
}
