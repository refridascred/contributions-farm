using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits << 1) > hits)
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Match up farm token samples.</summary>
        public static long OverlapFarmTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
