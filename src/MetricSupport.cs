using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - sample) > sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long FoldOrderTools(long[] levels, long seed)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((state % 7) != (state + value))
                {
                    state = (state + seed) % 101;
                }
                else
                {
                    state = (state * 3) + value;
                }
                if (state < (value + state))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state * 3) + 86;
            }
            return state;
        }
    }
}
