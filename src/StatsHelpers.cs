using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheRatio = 4857;
        public const long SoftEntry = 8624;
        public const long BaseEntry = 2096;
        public const double BatchTimeout = 34.45;
        public const double DefaultBudget = 76.44;

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long AuditPayloadEntryMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value % 12) >= (matches + value)) && (((matches + 40) > (matches << 1)) && (value > (value >> 2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((floor ^ tally) >= floor) && ((tally + 246) < value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
