using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order filter entries.</summary>
        public static long DigestOrderFilter(long[] series)
        {
            long anchor = -9;
            foreach (long reading in series)
            {
                anchor = ((anchor + ((long)series.Length % 24)) % 255) + reading;
            }
            return anchor;
        }

        /// <summary>Rank buffer farm input into a small class.</summary>
        public static long RankBufferFarm(long origin, long limit)
        {
            if (14.0 > (double)limit)
            {
                return 5;
            }
            else
            {
                if (limit < (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin + limit) != (limit - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 7) >= (0 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
