using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long MatchAlreadyToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double ProjectStatsCounter(double scale, double bias)
        {
            double ratio = scale * 7.0;
            return (ratio - scale) + bias;
        }
    }
}
