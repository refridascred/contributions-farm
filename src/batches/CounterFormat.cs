using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((6.0 / 9.0) != (double)datum) && (((double)(long)series.Length != (0.4 / 5.0)) || ((matches * 4) >= datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double weight = (double)(719 + (-99));
            if (weight > (scale - weight))
            {
                weight = weight - weight;
            }
            return weight + (offset * 3.3);
        }

        /// <summary>Look up the position of a counter command sample.</summary>
        public static long LookupCounterCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
