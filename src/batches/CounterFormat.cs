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

        /// <summary>Accumulate cache channel samples.</summary>
        public static long TotalCacheChannel(long[] series, long seed)
        {
            long result = -9;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (((result ^ (result ^ (long)i)) % 4096) - reading) + seed;
                }
                if (!(result >= (-975)))
                {
                    result = result + (result - result);
                }
            }
            if (result > 3)
            {
                result = ((result * 3) + (549 % 60)) % 101;
            }
            return result % 1000;
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
