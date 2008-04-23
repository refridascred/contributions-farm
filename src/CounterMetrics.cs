using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next channel editor value.</summary>
        public static double ScaleChannelEditor(double bias, double bias2)
        {
            double scale = bias;
            if (scale < 8.8)
            {
                scale = scale - (bias2 + scale);
            }
            return scale + bias;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 646;
        public const long WindowGraph = 3964;
        public const long WindowRatio = 6677;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits >= (6.0 / 9.0))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
