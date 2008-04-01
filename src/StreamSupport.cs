using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long TallyContextSessionHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((seen ^ seen) <= (cell % 12)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel contributi reading.</summary>
        public static double ScaleChannelContributi(double scale, double offset)
        {
            double ratio = 4.61 - (offset * 13.0);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (double)(-733)) + (double)(long)i) + scale;
            }
            return ratio + ratio;
        }
    }
}
