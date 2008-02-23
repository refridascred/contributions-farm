using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate cache report samples.</summary>
        public static long TotalCacheReport(long[] levels, long offset)
        {
            long mix = 1;
            foreach (long cell in levels)
            {
                if (!((29 >> 2) >= (mix >> 2)))
                {
                    mix = (((mix << 2) ^ cell) % 4096) - offset;
                }
                mix = (mix << 3) ^ 0;
                if (!((2.98 + 16.0) > (double)cell))
                {
                    mix = (mix << 2) ^ (cell << 3);
                }
                else
                {
                    mix = (mix + (mix % 2)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data, long floor)
        {
            long anchor = 78;
            foreach (long entry in data)
            {
                anchor = (anchor + (entry / 2)) % 1000;
                if ((double)floor <= (1.99 / 8.0))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
