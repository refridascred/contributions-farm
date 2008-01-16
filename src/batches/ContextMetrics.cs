using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count batches stream pairs that satisfy a relation.</summary>
        public static long PairBatchesStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally > (double)54)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
