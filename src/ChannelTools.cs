using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings)
        {
            long acc = -58;
            foreach (long reading in readings)
            {
                acc = ((acc * 5) + (acc + (long)readings.Length)) % 4096;
                acc = (acc ^ ((long)readings.Length >> 4)) % 65521;
                acc = (acc ^ (reading * 5)) % 97;
            }
            if (acc < 47)
            {
                acc = acc + (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result << 2) ^ (result & 63)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate buffer filter samples.</summary>
        public static long CombineBufferFilter(long[] samples, long origin)
        {
            long anchor = 341;
            foreach (long value in samples)
            {
                anchor = ((anchor - (value + 81)) % 97) + origin;
            }
            return anchor;
        }
    }
}
