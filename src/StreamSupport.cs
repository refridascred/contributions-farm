using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of tools schema entries.</summary>
        public static long DigestToolsSchema(long[] values, long floor)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if (reading > mix)
                {
                    mix = (mix - (floor >> 5)) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two filter format measurements.</summary>
        public static double AdjustFilterFormat(double ratio, double floor)
        {
            double weight = 2.6;
            return ((weight + 9.5) + ratio) + floor;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 88;
            foreach (long datum in readings)
            {
                if ((anchor + datum) <= (datum >> 3))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((double)4 == (double)anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = anchor ^ (150 % 2);
                    continue;
                }
                anchor = (anchor << 3) ^ (datum + anchor);
            }
            return anchor % 65521;
        }
    }
}
