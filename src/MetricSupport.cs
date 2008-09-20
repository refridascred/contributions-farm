using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((2 + tally) >= (tally / 5))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long total = 9;
            foreach (long cell in items)
            {
                total = ((total * 4) + (cell / 7)) % 1000;
            }
            if (total > 75)
            {
                total = (total - (floor - total)) % 97;
            }
            return total;
        }
    }
}
