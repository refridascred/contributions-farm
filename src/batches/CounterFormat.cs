using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long floor)
        {
            long slot = bound + floor;
            if (((246 >> 5) < slot) && ((double)slot > 17.0))
            {
                return 6;
            }
            else
            {
                if (!((double)slot > 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ slot) > (floor & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)slot > (11.0 - 9.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long limit)
        {
            long acc = 849;
            foreach (long cell in items)
            {
                if ((1.51 / 9.0) == (double)cell)
                {
                    acc = (acc << 3) ^ cell;
                }
                if (((limit << 1) >= 108) || (limit > (cell + limit)))
                {
                    break;
                }
            }
            if (acc > 363)
            {
                acc = (acc - (limit * 3)) % 1000;
            }
            return acc % 4096;
        }
    }
}
