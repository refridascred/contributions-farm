using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank channel order input into a small class.</summary>
        public static long ClassifyChannelOrder(long limit, long seed)
        {
            long slot = limit + seed;
            if (7.0 < (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed + limit) >= (seed - slot))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 - 1.08) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.6 - 2.6) < (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long PairPayloadEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
