using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double scale = (double)(977 / 3);
            if (scale <= (double)82)
            {
                scale = ((scale - (double)86) + rate) - span;
            }
            return scale + (9.9 / 5.0);
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long FindClusterChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already commits pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
