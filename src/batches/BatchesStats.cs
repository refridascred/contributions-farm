using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchFactor = 909;
        public const double LimitInterval = 34.56;
        public const long HardCommits = 7575;
        public const long BaseCommits = 31;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double load = 4.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (scale / 9.0)) + (double)(long)i;
            }
            return load - (load + bias);
        }
    }
}
