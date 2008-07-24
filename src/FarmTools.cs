using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token stats samples are out of range.</summary>
        public static long MeasureTokenStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (9.44 * 7.11))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route stats sample.</summary>
        public static long FindRouteStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
