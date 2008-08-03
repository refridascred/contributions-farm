using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cache metrics samples are out of range.</summary>
        public static long TallyCacheMetricsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((floor - matches) == (sample + sample)) && !((55 + 814) >= (floor % 100)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm cache counter forward.</summary>
        public static long StepFarmCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
