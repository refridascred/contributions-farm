using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "fallback-1";
        public const string WindowAlready = "primary-edge";
        public const long WindowScore = 1648;
        public const long MinSpan = 6016;

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
