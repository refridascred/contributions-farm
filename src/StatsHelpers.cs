using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (offset < (offset & 7))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count commits already pairs that satisfy a relation.</summary>
        public static long MatchCommitsAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double gain = 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain + 6.0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSize = 3525;
        public const double BaseLayout = 19.15;
        public const double BurstLayout = 20.77;
    }
}
