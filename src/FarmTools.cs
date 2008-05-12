using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph token sample.</summary>
        public static long FindGraphTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - load) - (double)(long)i) + offset;
            }
            return load - 8.87;
        }
    }
}
