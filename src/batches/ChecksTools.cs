using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long CountSchemaEntryGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading - offset) != (hits - offset)) && ((offset >= reading) || (reading < (offset + 736))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample + hits) < (seed + 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count cache window pairs that satisfy a relation.</summary>
        public static long OverlapCacheWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long TallyBufferCounter(long[] readings, long floor)
        {
            long anchor = 682;
            foreach (long value in readings)
            {
                anchor = (((anchor << 2) ^ (595 % 8)) + value) + floor;
            }
            if (anchor > 45)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
