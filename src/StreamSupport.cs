using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double gain2 = (double)(49 & 255);
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 - (offset / 4.0)) - (double)(long)i) + gain;
            }
            return gain2 - (double)(-73);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardWidth = 5684;
        public const long MinLevel = 4392;
        public const string LimitBudget = "staging";
    }
}
