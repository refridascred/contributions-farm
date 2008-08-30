using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings, long floor)
        {
            long result = -55;
            foreach (long item in readings)
            {
                if (2.2 <= (double)floor)
                {
                    result = ((result - (floor >> 5)) % 65521) ^ item;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long step)
        {
            if ((2.6 / 2.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor & 63) != (step - floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long seed)
        {
            long score = 797;
            foreach (long sample in samples)
            {
                if (((8.0 / 7.0) <= (double)seed) || ((16.0 * 9.2) > (2.3 / 8.0)))
                {
                    score = ((score * 4) + (sample & 63)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a token contributi reading by value.</summary>
        public static long LocateTokenContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
