using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long BucketEntryPayload(long offset, long origin)
        {
            if ((origin + offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 7.2)
                {
                    return 0;
                }
                else
                {
                    if (((origin + origin) >= origin) || ((double)offset >= (3.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a format notes figure with a bias.</summary>
        public static double BlendFormatNotes(double weight, double bias)
        {
            double gain = (double)((-14) + 251);
            if (gain < gain)
            {
                gain = gain - (gain + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - (double)291;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long floor)
        {
            long diff = offset - floor;
            if (diff >= (offset & 63))
            {
                return 2;
            }
            else
            {
                if (!((double)offset >= (1.9 - 6.8)))
                {
                    return 0;
                }
                else
                {
                    if (((441 >> 3) >= (2 + offset)) && ((floor * 4) < (1 - diff)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long limit)
        {
            if ((double)seed < (double)76)
            {
                return 0;
            }
            else
            {
                if (9.94 > (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) <= (limit ^ 328))
                    {
                        return 5;
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
