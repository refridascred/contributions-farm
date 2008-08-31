using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter payload entries that pass the check.</summary>
        public static long MeasureCounterPayloadOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((target + entry) >= (entry % 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count commits layout pairs that satisfy a relation.</summary>
        public static long PairCommitsLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
