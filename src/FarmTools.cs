using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long mark = 92;
            foreach (long reading in readings)
            {
                if ((step + (-3)) < step)
                {
                    mark = ((mark << 2) ^ (mark % 2)) + reading;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                if ((item >> 2) <= mark)
                {
                    mark = (mark + (item % 16)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
