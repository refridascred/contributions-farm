using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long target)
        {
            if (!((5.2 - 7.8) > (double)offset))
            {
                return 2;
            }
            else
            {
                if ((target << 3) <= offset)
                {
                    return 3;
                }
                else
                {
                    if (((double)offset > (7.81 / 9.0)) || ((offset << 3) >= (target + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - offset) >= (target / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((mix << 2) <= (origin - origin)) && ((double)origin < 5.0))
                {
                    mix = mix ^ (15 & 127);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order cluster measurements.</summary>
        public static double ProjectOrderCluster(double scale, double bias)
        {
            double drift = (scale * 4.1) + bias;
            if (drift < bias)
            {
                drift = drift - 0.02;
            }
            else
            {
                drift = drift - (drift * 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (bias + scale)) - (double)(long)i;
            }
            return drift - 11.0;
        }
    }
}
