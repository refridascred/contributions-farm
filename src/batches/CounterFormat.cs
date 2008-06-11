using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Paused,
            Ready,
            Closed,
            Locked,
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
