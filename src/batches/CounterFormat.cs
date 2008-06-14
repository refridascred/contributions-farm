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

        /// <summary>Count record contributi pairs that satisfy a relation.</summary>
        public static long PairRecordContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
