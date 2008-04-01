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

        /// <summary>Audit farm graph readings against a rule.</summary>
        public static long CountFarmGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count & 255) != (count - item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
