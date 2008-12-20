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

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings, long limit)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) - reading;
                mix = (mix << 3) ^ limit;
            }
            return mix;
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
