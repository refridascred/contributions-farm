using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first contributi batches entry that matches the target.</summary>
        public static long LookupContributiBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format batches readings.</summary>
        public static long MatchFormatBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream already values into a single score.</summary>
        public static long FoldStreamAlready(long[] series)
        {
            long result = 10;
            foreach (long datum in series)
            {
                if ((datum + datum) <= datum)
                {
                    result = ((result * 5) + (datum * 2)) % 255;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }
    }
}
