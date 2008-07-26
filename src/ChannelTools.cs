using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((offset / 5) <= offset) || (offset > (value / 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((mix + target) > mix)
                {
                    long offset = (mix + target) * 5;
                    mix = (mix - (offset - 1)) % 65521;
                }
                mix = (mix << 2) ^ ((long)i >> 4);
                mix = (mix + (317 + target)) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
