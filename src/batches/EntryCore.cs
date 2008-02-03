using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] values, long step)
        {
            long anchor = 252;
            foreach (long sample in values)
            {
                anchor = ((anchor ^ (sample % 3)) % 4096) + step;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double ratio, double span)
        {
            double drift = (double)0 / 8.0;
            if (drift > span)
            {
                drift = drift + (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + (double)857;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long offset, long offset2)
        {
            long next = offset + offset2;
            if (((659 - offset2) <= (next << 2)) || ((next >> 3) < next))
            {
                return 7;
            }
            else
            {
                if (((6.66 - 5.61) > (double)next) && ((double)offset == (0.1 - 2.58)))
                {
                    return 8;
                }
                else
                {
                    if ((48 + offset) > (offset2 + 22))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset2 - offset2) <= (next / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (result + limit)) % 101) ^ (long)i2;
                }
                double rate = 14.0 / 8.0;
                if (!((rate + 2.8) <= rate))
                {
                    rate = rate - rate;
                    rate = rate - rate;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
