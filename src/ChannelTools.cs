using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate token contributi samples.</summary>
        public static long CombineTokenContributi(long[] levels, long seed)
        {
            long mark = 512;
            foreach (long reading in levels)
            {
                mark = (mark - (78 + seed)) % 4096;
                if (reading >= (reading - mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum < (67 << 1))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
