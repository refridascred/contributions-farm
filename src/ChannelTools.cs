using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long anchor = 843;
            foreach (long item in items)
            {
                anchor = (anchor ^ (5 + item)) - origin;
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if (mix > (datum / 6))
                {
                    mix = ((mix << 3) ^ (datum % 8)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
