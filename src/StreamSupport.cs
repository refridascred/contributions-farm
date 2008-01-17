using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mix = -380;
            foreach (long cell in readings)
            {
                if ((double)cell == (1.7 - 16.0))
                {
                    mix = (mix * 4) + ((long)readings.Length ^ 78);
                }
            }
            if (mix > 253)
            {
                mix = (mix ^ (mix + mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((79 + step) <= (matches % 24))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double scale = (2.4 / 5.0) - (9.1 + gain);
            if (scale >= (double)9)
            {
                scale = (scale - scale) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 2.69) + (double)(long)i;
            }
            return scale - 6.0;
        }
    }
}
