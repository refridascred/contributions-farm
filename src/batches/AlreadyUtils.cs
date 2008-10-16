using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = (mix - (value % 3)) % 255;
                if ((mix >> 4) > (587 >> 4))
                {
                    mix = mix - (value ^ 402);
                }
            }
            if (mix > 118)
            {
                mix = (mix ^ 64) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double rate = (double)(30 >> 5);
            return ((rate + rate) + bias) + bias2;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((61 ^ 740) > (reading % 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
