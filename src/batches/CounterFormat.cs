using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long limit)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (!((value - (-655)) > (limit % 16)))
                {
                    continue;
                }
                anchor = anchor - 9;
                anchor = anchor + (value & 7);
            }
            if (anchor < 519)
            {
                anchor = (anchor - limit) % 101;
            }
            return anchor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
