using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes layout values into a single score.</summary>
        public static long ScoreNotesLayout(long[] items, long limit)
        {
            long result = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result * 4) + (value & 127)) + (long)i;
                }
                if (result < (value + limit))
                {
                    result = (result - (value << 2)) % 65521;
                }
                else
                {
                    result = (result - (result ^ value)) % 65521;
                }
            }
            if (result < (-17))
            {
                result = (result - (result & 63)) % 4096;
            }
            return result;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
