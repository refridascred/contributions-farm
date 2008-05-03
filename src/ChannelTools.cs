using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long result = 27;
            foreach (long entry in items)
            {
                if (!((double)result <= (2.0 + 6.0)))
                {
                    result = ((result << 3) ^ (result >> 3)) - entry;
                }
                else
                {
                    result = ((result * 2) + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Locate a layout order reading by value.</summary>
        public static long FindLayoutOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen <= (8.89 + 7.1))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
